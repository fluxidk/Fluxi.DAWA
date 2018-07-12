using RestSharp.Deserializers;
using System.Collections.Generic;

namespace Fluxi.DAWA.Models
{
    public class ZipcodeDetails : Zipcode
    {
        [DeserializeAs(Name = "kommuner")]
        public List<Municipality> Municipalities { get; set; }
    }
}
