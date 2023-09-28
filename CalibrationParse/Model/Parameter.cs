namespace CalibrationParse.Model
{
    public class Parameter
    {
        public Parameter(string parameterName, string measureUnit, string dataType, string description)
        {
            ParameterName = parameterName.PadRight(4, ' ');
            MeasureUnit = measureUnit.PadRight(4, ' ');
            Description = description;
            DataType = dataType;
        }

        public Parameter(Parameter parameter)
        {
            ParameterName = parameter.ParameterName;
            MeasureUnit = parameter.MeasureUnit;
            Description = parameter.Description;
            DataType = parameter.DataType;
        }

        public string ParameterName { get; private set; }
        public string MeasureUnit { get; private set; }
        public string Description { get; private set; }
        
        public string Value { get; set; }
        public string DataType { get; private set; }

        public override string ToString() => $"{ParameterName}.{MeasureUnit}.{DataType} : {Value}";
    }
}