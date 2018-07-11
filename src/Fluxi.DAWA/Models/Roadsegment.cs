using RestSharp.Deserializers;

namespace Fluxi.DAWA.Models
{
    public class Roadsegment
    {
        [DeserializeAs(Name = "navn")]
        public string Name { get; set; }

        [DeserializeAs(Name = "adresseringsnavn")]
        public string AddressingName { get; set; }

        [DeserializeAs(Name = "kode")]
        public string Code { get; set; }
    }
}
