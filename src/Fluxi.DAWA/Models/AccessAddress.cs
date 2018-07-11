using RestSharp.Deserializers;

namespace Fluxi.DAWA.Models
{
    public class AccessAddress
    {
        public string Id { get; set; }
        public string KVH { get; set; }
        public int Status { get; set; }

        [DeserializeAs(Name = "husnr")]
        public string HouseNo { get; set; }

        [DeserializeAs(Name = "historik")]
        public History History { get; set; }

        [DeserializeAs(Name = "vejstykke")]
        public Roadsegment Roadsegment { get; set; }

        [DeserializeAs(Name = "postnummer")]
        public Zipcode Zipcode { get; set; }

        [DeserializeAs(Name = "kommune")]
        public Municipality Municipality { get; set; }

        public string Zone { get; set; }
    }
}
