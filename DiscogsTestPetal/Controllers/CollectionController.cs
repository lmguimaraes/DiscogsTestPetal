using DiscogsTestPetal.DataAccess;
using DiscogsTestPetal.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DiscogsTestPetal.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CollectionController : Controller
    {
        private readonly ILogger<CollectionController> _logger;
        private readonly IDiscCollectionData _discCollectionData;

        public CollectionController(ILogger<CollectionController> logger, IDiscCollectionData discCollectionData)
        {
            _logger = logger;
            _discCollectionData = discCollectionData;
        }
        // GET
        /// <summary>
        /// Retrieves disc collection
        /// </summary>
        [HttpGet]
        [Route("GetCollection/{qty}")]
        public string GetCollectionAsync(int qty)
        {
            var result = new Collection();
            _logger.LogDebug("'{0}' has been invoked", nameof(GetCollectionAsync));
            try
            {
                return  JsonConvert.SerializeObject((RandomizeDiscs( _discCollectionData.GetCollectionInfo(qty).Result.Releases, qty)));
            }
            catch (Exception ex)
            {
                _logger.LogCritical("There was an error on '{0}' invocation: {1}", nameof(GetCollectionAsync), ex);
                return ex.Message;
            }
        }

        public IEnumerable<Releases> RandomizeDiscs(List<Releases> allDiscs, int quantity)
        {
            Random rnd = new Random();
            var randomizedDiscs = new List<Releases>();
            var uniqueNumbers = GenerateRandomNumbers(quantity);
            foreach (var item in uniqueNumbers)
            {
                randomizedDiscs.Add(allDiscs[item]);
            }
            return randomizedDiscs;
        }

        public HashSet<int> GenerateRandomNumbers(int quantity)
        {
            HashSet<int> rndIndexes = new HashSet<int>();
            Random rng = new Random();
            Console.Write("Please input Max number: ");
            while (rndIndexes.Count != quantity)
            {
                int index = rng.Next(50);
                rndIndexes.Add(index);
            }
            return rndIndexes;
        }
    }
}
