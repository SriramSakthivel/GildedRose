using System;

namespace GildedRose.Console
{
    public class RegularUpdateQualityRule : UpdateQualityRuleBase
    {
        public RegularUpdateQualityRule(Item item)
            : base(item)
        {
        }

        protected override void UpdateQualityCore()
        {
            Item.Quality--;
        }

        protected override void UpdateSellIn()
        {
            Item.SellIn--;
            if (Item.SellIn < 0)
            {
                Item.Quality--;
            }
        }

        protected override void FixQualityRange()
        {
            Item.Quality = Math.Min(Item.Quality, 50);
            Item.Quality = Math.Max(Item.Quality, 0);
        }
    }
}