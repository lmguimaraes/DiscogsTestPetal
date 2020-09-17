using DiscogsTestPetal.Controllers;
using DiscogsTestPetal.DataAccess;
using DiscogsTestPetal.Models;
using Microsoft.Extensions.Logging;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DiscogsTestPetal.TEST
{
    [TestFixture]
    public class CollectionControllerTST
    {
        private readonly ILogger<CollectionController> _logger;
        private readonly IDiscCollectionData _discCollectionData;
        private CollectionController _collectionController;

        public List<Releases> _releases = new List<Releases>();

        [SetUp]
        public void Setup()
        {
            _collectionController = new CollectionController(_logger, _discCollectionData);
        }

        [Test]
        public void GenerateRandomNumbers_ExpectedInput_ReturnsValidHashSet()
        {
            //Arrange
            int qty = 5;
            _releases = FillDiscsList(50);
            //Act
            var result = _collectionController.GenerateRandomNumbers(qty, _releases);
            //Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(qty, result.Count);
        }

        [Test]
        public void RandomizeDiscs_ValidInputs_ReturnsValidList()
        {
            //Arrange
            int qty = 3;
            _releases = FillDiscsList(10);
            //Act
            var result = _collectionController.RandomizeDiscs(_releases, qty).ToList();
            //Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(qty, result.Count);
        }


        [Test]
        public void RandomizeDiscs_QuantityLargerThanDiscList_ThrowsArgumentOutOfRangeException()
        {
            //Arrange
            int qty = 5;
            _releases = FillDiscsList(3);
            //Act
            //Assert
            Assert.Throws<ArgumentOutOfRangeException>(()=> _collectionController.RandomizeDiscs(_releases, qty).ToList());         
        }

        [Test]
        public void RandomizeDiscs_DiscListEmpty_ThrowsArgumentOutOfRangeException()
        {
            //Arrange
            int qty = 3;
            //Act
            //Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => _collectionController.RandomizeDiscs(_releases, qty).ToList());
        }

        [Test]
        public void RandomizeDiscs_QuantityEqualsZero_ReturnsEmptyList()
        {
            //Arrange
            int qty = 0;
            _releases = FillDiscsList(10);
            //Act
            var result = _collectionController.RandomizeDiscs(_releases, qty).ToList();
            //Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(0, result.Count);
        }

        public List<Releases> FillDiscsList(int quantity)
        {
            var returnList = new List<Releases>();
            for (int i = 0; i < quantity; i++)
            {
                returnList.Add(new Releases
                {
                    Id = i
                });
            }
            return returnList;
        }
    }
}