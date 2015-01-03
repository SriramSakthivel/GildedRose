using GildedRose.Console;
using NUnit.Framework;

namespace GildedRose.Tests
{
    [TestFixture]
    public class AgedBrieTests
    {
        private const string ItemName = "Aged Brie";

        [Test]
        public void ShouldIncreaseQualityByOne()
        {
            Item item = new Item() { Name = ItemName, Quality = 10, SellIn = 1 };
            var qualityUpdater = new ItemQualityUpdater(new[] { item });
            qualityUpdater.UpdateQuality();

            Assert.GreaterOrEqual(item.Quality, 11);
        }

        [Test]
        public void QualityIsNeverGreaterThan50()
        {
            Item item = new Item() { Name = ItemName, Quality = 50, SellIn = 1 };
            var qualityUpdater = new ItemQualityUpdater(new[] { item });
            qualityUpdater.UpdateQuality();

            Assert.AreEqual(50, item.Quality);
        }
    }
}