using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.Text;

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
