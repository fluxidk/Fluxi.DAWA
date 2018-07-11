using System;

namespace Fluxi.DAWA.Requests
{
    public class ParameterDescriptionAttribute : Attribute
    {
        public string ParameterName { get; set; }

        public ParameterDescriptionAttribute(string parameterName)
        {
            ParameterName = parameterName;
        }
    }
}
