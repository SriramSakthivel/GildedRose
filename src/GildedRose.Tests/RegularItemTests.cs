﻿using GildedRose.Console;
using NUnit.Framework;

namespace GildedRose.Tests
{
    [TestFixture]
    public class RegularItemTests
    {
        private const string ItemName = "RegularItem";

        [Test]
        public void DegradeQualityByOneWhenSellInAvailable()
        {
            Item item = new Item() { Name = ItemName, Quality = 10, SellIn = 5 };
            var qualityUpdater = new ItemQualityUpdater(new[] { item });
            qualityUpdater.UpdateQuality();

            Assert.AreEqual(9, item.Quality);
        }

        [Test]
        public void DegradeQualityByTwoWhenSellInPassed()
        {
            Item item = new Item() { Name = ItemName, Quality = 10, SellIn = 0 };
            var qualityUpdater = new ItemQualityUpdater(new[] { item });
            qualityUpdater.UpdateQuality();

            Assert.AreEqual(8, item.Quality);
        }

        [Test]
        public void DegradeSellInByOne()
        {
            Item item = new Item() { Name = ItemName, Quality = 10, SellIn = 5 };
            var qualityUpdater = new ItemQualityUpdater(new[] { item });
            qualityUpdater.UpdateQuality();

            Assert.AreEqual(4, item.SellIn);
        }

        [Test]
        public void QualityShouldNeverBeLessThanZero()
        {
            Item item = new Item() { Name = ItemName, Quality = 1, SellIn = 0 };
            var qualityUpdater = new ItemQualityUpdater(new[] { item });
            qualityUpdater.UpdateQuality();

            Assert.GreaterOrEqual(0, item.Quality);
        }
    }
}
