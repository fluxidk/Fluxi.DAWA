using RestSharp.Deserializers;

namespace Fluxi.DAWA.Models
{
    public class Municipality
    {
        [DeserializeAs(Name = "navn")]
        public string Name { get; set; }

        [DeserializeAs(Name = "kode")]
        public string Code { get; set; }
    }
}
