namespace GildedRose.Console.Rules
{
    public class BackstagePassesUpdateQualityRule : UpdateQualityRuleBase
    {
        public BackstagePassesUpdateQualityRule(Item item)
            : base(item)
        {
        }

        protected override void UpdateQualityCore()
        {
            Item.Quality++;

            if (Item.SellIn < 11)
            {
                Item.Quality++;
            }
            if (Item.SellIn < 6)
            {
                Item.Quality++;
            }
        }

        protected override void UpdateSellIn()
        {
            Item.SellIn--;
            if (Item.SellIn < 0)
            {
                Item.Quality = 0;
            }
        }

        protected override void FixQualityRange()
        {

        }
    }
}