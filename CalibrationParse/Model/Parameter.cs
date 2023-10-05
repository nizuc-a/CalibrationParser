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
            IsSelected = true;
        }

        public Parameter(Parameter parameter)
        {
            ParameterName = parameter.ParameterName;
            MeasureUnit = parameter.MeasureUnit;
            Description = parameter.Description;
            DataType = parameter.DataType;
            IsSelected = true;
        }

        public string ParameterName { get; }
        public string MeasureUnit { get; }
        public string Description { get; }
        public string Value { get; set; }
        public string DataType { get;  }
        public bool IsSelected { get; set; }

        public override string ToString() => $"{ParameterName}.{MeasureUnit}.{DataType} : {Value}";
    }
}