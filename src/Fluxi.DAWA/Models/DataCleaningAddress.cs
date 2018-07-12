using RestSharp.Deserializers;
using System;

namespace Fluxi.DAWA.Models
{
    public class DataCleaningAddress
    {
        public string Id { get; set; }

        [DeserializeAs(Name = "vejnavn")]
        public string Roadname { get; set; }
        [DeserializeAs(Name = "adresseringsvejnavn")]
        public string RoadnameShort { get; set; }
        [DeserializeAs(Name = "husnr")]
        public string HouseNo { get; set; }
        [DeserializeAs(Name = "postnr")]
        public string Zipcode { get; set; }
        [DeserializeAs(Name = "postnrnavn")]
        public string ZipcodeName { get; set; }
        [DeserializeAs(Name = "status")]
        public int Status { get; set; }
        [DeserializeAs(Name = "virkningstart")]
        public DateTime? ValidFrom { get; set; }
        [DeserializeAs(Name = "virkningslut")]
        public DateTime? ValidTo { get; set; }
        [DeserializeAs(Name = "adgangsadresseid")]
        public string AccessAddressId { get; set; }
        [DeserializeAs(Name = "etage")]
        public string Floor { get; set; }
        [DeserializeAs(Name = "dør")]
        public string Door { get; set; }
    }
}
