using Newtonsoft.Json;

namespace DiscogsTestPetal.Models
{
    public class Artists
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        [JsonProperty(PropertyName = "anv")]
        public string Anv { get; set; }
        [JsonProperty(PropertyName = "join")]
        public string Join { get; set; }
        [JsonProperty(PropertyName = "role")]
        public string Role { get; set; }
        [JsonProperty(PropertyName = "tracks")]
        public string Tracks { get; set; }
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }
        [JsonProperty(PropertyName = "resource_url")]
        public string ResourceUrl { get; set; }
    }
}
