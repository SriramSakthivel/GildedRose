using GildedRose.Console;
using NUnit.Framework;

namespace GildedRose.Tests
{
    [TestFixture]
    public class LegendaryItemTests
    {
        private const string ItemName = "Sulfuras, Hand of Ragnaros";

        [Test]
        public void ShouldNeverDecreaseQuality()
        {
            Item item = new Item() { Name = ItemName, Quality = 80, SellIn = 10 };
            var qualityUpdater = new ItemQualityUpdater(new[] { item });
            qualityUpdater.UpdateQuality();

            Assert.AreEqual(80, item.Quality);
        } 
        
        [Test]
        public void ShouldNeverDecreaseSellIn()
        {
            Item item = new Item() { Name = ItemName, Quality = 80, SellIn = 10 };
            var qualityUpdater = new ItemQualityUpdater(new[] { item });
            qualityUpdater.UpdateQuality();

            Assert.AreEqual(10, item.SellIn);
        }
    }
}