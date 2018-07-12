using RestSharp.Deserializers;
using System.Collections.Generic;

namespace Fluxi.DAWA.Models
{
    public class DataCleaning
    {
        [DeserializeAs(Name = "kategori")]
        public DataCleaningCategory Category { get; set; }

        [DeserializeAs(Name = "resultater")]
        public List<DataCleaningResult> Results { get; set; }
    }
}
