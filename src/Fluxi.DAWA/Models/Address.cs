using RestSharp.Deserializers;

namespace Fluxi.DAWA.Models
{
    public class Address
    {
        public string Id { get; set; }
        public string KVHX { get; set; }
        public int Status { get; set; }

        [DeserializeAs(Name = "etage")]
        public string Floor { get; set; }

        [DeserializeAs(Name = "dør")]
        public string Door { get; set; }

        [DeserializeAs(Name = "adressebetegnelse")]
        public string FullAddress { get; set; }

        [DeserializeAs(Name = "historik")]
        public History History { get; set; }

        [DeserializeAs(Name = "adgangsadresse")]
        public AccessAddress AccessAddress { get; set; }
    }
}
