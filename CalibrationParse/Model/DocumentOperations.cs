using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CalibrationParse.Model
{
    public static class DocumentOperations
    {
        public static int FindPosition(string path)
        {
            var fullText = ReadCP866File(path);
            string keyword = "~Records\r\n";
            var keywordIndex = fullText.IndexOf(keyword);

            if (keywordIndex != -1)
                return keywordIndex + keyword.Length;
            else
                return -1;
        }

        private static string ReadCP866File(string filePath)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            using (StreamReader reader = new StreamReader(filePath, Encoding.GetEncoding(866)))
            {
                return reader.ReadToEnd();
            }
        }

        public static IEnumerable<byte[]> ReadBinaryFile(string filePath, int startIndex, int length)
        {
            using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                fileStream.Position = startIndex;
                byte[] binaryData = new byte[length];
                using (BinaryReader binaryReader = new BinaryReader(fileStream, Encoding.GetEncoding(866)))
                {
                    while (fileStream.Position < fileStream.Length)
                    {
                        yield return binaryReader.ReadBytes(binaryData.Length);
                    }
                }
            }
        }

        public static List<Parameter> FillParameterDescription(string path, out int weight)
        {
            weight = 0;
            var result = new List<Parameter>();
            var body = ReadCP866File(path)
                .Split("#-----------------------------------------------------------------------------")
                .Skip(3)
                .First()
                .Trim();
            var parameter = body.Split("\r\n").Select(s=>s.TrimStart()).ToArray();
            for (int i = 0; i < parameter.Length - 1; i++)
            {
                var name = parameter[i].Substring(0, 4);
                var measureUnit = parameter[i].Substring(5, 4);
                var dataType = parameter[i].Substring(10, 4);
                var description = parameter[i].Substring(parameter[i].IndexOf(':') + 1);

                weight += GetWeight(dataType);
                var tempParameter = new Parameter(name, measureUnit, dataType, description);
                result.Add(tempParameter);
            }

            return result;
        }

        public static List<Parameter> FillParameterValue(List<Parameter> rawParameters, byte[] data)
        {
            var result = rawParameters.Select(x=>new Parameter(x)).ToList();
            
            using (MemoryStream memoryStream = new MemoryStream(data))
            {
                using (BinaryReader binaryReader = new BinaryReader(memoryStream))
                {
                    var dict = new Dictionary<string, Func<string>>();
                    dict["7906"] = () => binaryReader.ReadInt16().ToString();
                    dict["6508"] = () => string.Join("", binaryReader.ReadChars(8));
                    dict["6808"] = () => binaryReader.ReadSingle().ToString();
                    
                    for (int i = 0; i < result.Count; i++)
                    {
                        result[i].Value = dict[result[i].DataType]();
                    }
                }
            }

            return result;
        }

        private static int GetWeight(string dataType) =>
            dataType switch
            {
                "7906" => 2,
                "6508" => 8,
                "6808" => 4,
                _ => throw new ArgumentException("Такого типа данных нет.")
            };
    }
}