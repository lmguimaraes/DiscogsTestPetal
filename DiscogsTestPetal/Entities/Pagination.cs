using Newtonsoft.Json;

namespace DiscogsTestPetal.Models
{
    public class Pagination
    {
        [JsonProperty(PropertyName = "page")]
        public int Page { get; set; }
        [JsonProperty(PropertyName = "pages")]
        public int Pages { get; set; }
        [JsonProperty(PropertyName = "per_page")]
        public int PerPage { get; set; }
        [JsonProperty(PropertyName = "items")]
        public int Items { get; set; }
        [JsonProperty(PropertyName = "urls")]
        public Urls Url { get; set; }
    }
}
