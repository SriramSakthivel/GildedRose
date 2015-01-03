using GildedRose.Console;
using NUnit.Framework;

namespace GildedRose.Tests
{
    [TestFixture]
    public class BackstagePassesTests
    {
        private const string ItemName = "Backstage passes to a TAFKAL80ETC concert";

        [Test]
        [TestCase(10), TestCase(9),
        TestCase(8), TestCase(7), TestCase(6)]
        public void ShouldIncreaseByTwoWhenSellInLessThan10(int sellIn)
        {
            Item item = new Item() { Name = ItemName, Quality = 10, SellIn = sellIn };
            var qualityUpdater = new ItemQualityUpdater(new[] { item });
            qualityUpdater.UpdateQuality();

            Assert.AreEqual(12, item.Quality);
        }

        [Test]
        [TestCase(5), TestCase(4),
        TestCase(3), TestCase(2), TestCase(1)]
        public void ShouldIncreaseByTwoWhenSellInLessThan5(int sellIn)
        {
            Item item = new Item() { Name = ItemName, Quality = 10, SellIn = sellIn };
            var qualityUpdater = new ItemQualityUpdater(new[] { item });
            qualityUpdater.UpdateQuality();

            Assert.AreEqual(13, item.Quality);
        }

        [Test]
        public void ShouldBeZeroWhenSellInIsZero()
        {
            Item item = new Item() { Name = ItemName, Quality = 10, SellIn = 0 };
            var qualityUpdater = new ItemQualityUpdater(new[] { item });
            qualityUpdater.UpdateQuality();

            Assert.AreEqual(0, item.Quality);
        } 
    }
}