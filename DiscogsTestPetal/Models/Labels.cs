using Newtonsoft.Json;

namespace DiscogsTestPetal.Models
{
    public class Labels
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        [JsonProperty(PropertyName = "catno")]
        public string CatNumber { get; set; }
        [JsonProperty(PropertyName = "entity_type")]
        public string EntityType { get; set; }
        [JsonProperty(PropertyName = "entity_type_name")]
        public string EntityTypeName { get; set; }
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }
        [JsonProperty(PropertyName = "resource_url")]
        public string ResourceUrl { get; set; }
    }
}