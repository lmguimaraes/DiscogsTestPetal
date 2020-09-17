using DiscogsTestPetal.DataAccess;
using DiscogsTestPetal.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

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
        public string GetCollection(int qty)
        {
            var result = new Collection();
            _logger.LogDebug("'{0}' has been invoked", nameof(GetCollection));
            try
            {
                return JsonConvert.SerializeObject((RandomizeDiscs(_discCollectionData.GetCollectionInfoAsync(qty).Result.Releases, qty)));
            }
            catch (Exception ex)
            {
                _logger.LogCritical("There was an error on '{0}' invocation: {1}", nameof(GetCollection), ex);
                return ex.Message;
            }
        }

        public IEnumerable<Releases> RandomizeDiscs(List<Releases> allDiscs, int quantity)
        {
            Random rnd = new Random();
            var randomizedDiscs = new List<Releases>();
            var uniqueNumbers = GenerateRandomNumbers(quantity, allDiscs);
            foreach (var item in uniqueNumbers)
            {
                randomizedDiscs.Add(allDiscs[item]);
            }
            return randomizedDiscs;
        }

        public HashSet<int> GenerateRandomNumbers(int quantity, List<Releases> discsList)
        {
            HashSet<int> rndIndexes = new HashSet<int>();
            Random rng = new Random();
            if (quantity > discsList.Count)
                throw new ArgumentOutOfRangeException();
            while (rndIndexes.Count != quantity)
            {
                int index = rng.Next(discsList.Count);
                rndIndexes.Add(index);
            }
            return rndIndexes;
        }
    }
}
