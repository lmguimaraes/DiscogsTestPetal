using Newtonsoft.Json;
using System.Collections.Generic;

namespace DiscogsTestPetal.Models
{
    public class Formats
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        [JsonProperty(PropertyName = "qty")]
        public int Quantity { get; set; }
        [JsonProperty(PropertyName = "descriptions")]
        public List<string> Descriptions { get; set; }
    }
}
