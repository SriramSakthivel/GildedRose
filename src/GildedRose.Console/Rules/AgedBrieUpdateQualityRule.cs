using System;

namespace GildedRose.Console.Rules
{
    public class AgedBrieUpdateQualityRule : UpdateQualityRuleBase
    {
        public AgedBrieUpdateQualityRule(Item item)
            : base(item)
        {
        }

        protected override void UpdateQualityCore()
        {
            Item.Quality++;
        }

        protected override void UpdateSellIn()
        {
            Item.SellIn--;
            if (Item.SellIn < 0)
            {
                Item.Quality++;
            }
        }

        protected override void FixQualityRange()
        {
            Item.Quality = Math.Min(Item.Quality, 50);
        }
    }
}