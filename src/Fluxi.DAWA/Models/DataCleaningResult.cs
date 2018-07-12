using RestSharp.Deserializers;

namespace Fluxi.DAWA.Models
{
    public class DataCleaningResult
    {
        [DeserializeAs(Name = "adresse")]
        public DataCleaningAddress Address { get; set; }
        [DeserializeAs(Name = "aktueladresse")]
        public DataCleaningAddress CurrentAddress { get; set; }
    }
}
