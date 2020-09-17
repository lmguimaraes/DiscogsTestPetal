using DiscogsTestPetal.Models;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace DiscogsTestPetal.DataAccess
{
    public class DiscCollectionData : IDiscCollectionData
    {
        private readonly IConfiguration _configuration;
        private readonly string apiBaseUrl;
        public DiscCollectionData(IConfiguration configuration)
        {
            _configuration = configuration;

            apiBaseUrl = _configuration.GetValue<string>("WebAPIBaseUrl");
        }

        public async Task<Collection> GetCollectionInfoAsync(int quantity)
        {
            using (var httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Add("User-Agent", "X");
                var stringJson = await httpClient.GetStringAsync(apiBaseUrl);
                return JsonConvert.DeserializeObject<Collection>(stringJson.ToString());
            }
        }
    }
}

