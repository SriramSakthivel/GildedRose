using System;

namespace GildedRose.Console
{
    public class ConjuredUpdateQualityRule : UpdateQualityRuleBase
    {
        public ConjuredUpdateQualityRule(Item item)
            : base(item)
        {
        }

        protected override void UpdateQualityCore()
        {
            Item.Quality -= 2;
        }

        protected override void UpdateSellIn()
        {
            Item.SellIn--;
            if (Item.SellIn < 0)
            {
                Item.Quality -= 2;
            }
        }

        protected override void FixQualityRange()
        {
            Item.Quality = Math.Min(Item.Quality, 50);
            Item.Quality = Math.Max(Item.Quality, 0);
        }
    }
}