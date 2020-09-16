using Newtonsoft.Json;
using System.Collections.Generic;

namespace DiscogsTestPetal.Models
{
    public class BasicInformation
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }
        [JsonProperty(PropertyName = "master_id")]
        public int MasterId { get; set; }
        [JsonProperty(PropertyName = "master_url")]
        public string MasterUrl { get; set; }
        [JsonProperty(PropertyName = "resource_url")]
        public string ResourceUrl { get; set; }
        [JsonProperty(PropertyName = "thumb")]
        public string Thumb { get; set; }
        [JsonProperty(PropertyName = "cover_image")]
        public string CoverImage { get; set; }
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }
        [JsonProperty(PropertyName = "year")]
        public string Year { get; set; }
        [JsonProperty(PropertyName = "formats")]
        public List<Formats> Formats { get; set; }
        [JsonProperty(PropertyName = "labels")]
        public List<Labels> Labels { get; set; }
        [JsonProperty(PropertyName = "artists")]
        public List<Artists> Artists { get; set; }
        [JsonProperty(PropertyName = "genres")]
        public List<string> Genres { get; set; }
        [JsonProperty(PropertyName = "styles")]
        public List<string> Styles { get; set; }

    }
}