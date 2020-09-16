using Newtonsoft.Json;

namespace DiscogsTestPetal.Models
{
    public class Releases
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }
        [JsonProperty(PropertyName = "instance_id")]
        public int InstanceId { get; set; }
        [JsonProperty(PropertyName = "date_added")]
        public string DateAdded { get; set; }
        [JsonProperty(PropertyName = "rating")]
        public int Rating { get; set; }
        [JsonProperty(PropertyName = "basic_information")]
        public BasicInformation BasicInfo { get; set; }
    }
}
