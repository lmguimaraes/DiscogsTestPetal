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

        public async Task<Collection> GetCollectionInfo(int quantity)
        {
            using (var httpClient = new HttpClient())
            {
                var stringJson = httpClient.GetStringAsync(apiBaseUrl);
                var apiResponse = await stringJson;
                return JsonConvert.DeserializeObject<Collection>(apiResponse.ToString());
            }
            //var myJsonString = File.ReadAllText(@"json.json");
            //return JsonConvert.DeserializeObject<Collection>(myJsonString);
        }
    }
}

