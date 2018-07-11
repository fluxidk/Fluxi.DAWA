using RestSharp.Deserializers;

namespace Fluxi.DAWA.Models
{
    public class Zipcode
    {
        [DeserializeAs(Name = "navn")]
        public string Name { get; set; }
        
        [DeserializeAs(Name = "nr")]
        public string No { get; set; }
    }
}
