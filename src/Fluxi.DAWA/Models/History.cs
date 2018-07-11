using RestSharp.Deserializers;
using System;

namespace Fluxi.DAWA.Models
{
    public class History
    {
        [DeserializeAs(Name = "oprettet")]
        public DateTime Created { get; set; }

        [DeserializeAs(Name = "ændret")]
        public DateTime Changed { get; set; }
    }
}
