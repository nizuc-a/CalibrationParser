using System.Collections.Generic;
using System.Linq;

namespace CalibrationParse.Model
{
    public class Calibration
    {
        private List<Parameter> parameters;

        public Calibration( List<Parameter> parameters)
        {
            this.parameters = parameters;
        }

        public string GetHeader => $"{parameters[0].Value} : {parameters[1].Value}";
        public List<Parameter> GetBody => parameters.Skip(2).ToList();
    }
}