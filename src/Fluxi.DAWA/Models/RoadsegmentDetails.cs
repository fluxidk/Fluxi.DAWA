using RestSharp.Deserializers;
using System.Collections.Generic;

namespace Fluxi.DAWA.Models
{
    public class RoadsegmentDetails : Roadsegment
    {
        [DeserializeAs(Name = "kommune")]
        public Municipality Municipality { get; set; }

        [DeserializeAs(Name = "postnumre")]
        public List<Zipcode> Zipcodes { get; set; }

        [DeserializeAs(Name = "historik")]
        public History History { get; set; }
    }
}
