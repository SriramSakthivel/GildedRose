namespace GildedRose.Console.Rules
{
    public class UpdateQualityRuleFactory
    {
        public IUpdateQualityRule CreateUpdateQualityRule(Item item)
        {
            switch (item.Name)
            {
                case "Aged Brie":
                    return new AgedBrieUpdateQualityRule(item);
                case "Backstage passes to a TAFKAL80ETC concert":
                    return new BackstagePassesUpdateQualityRule(item);
                case "Sulfuras, Hand of Ragnaros":
                    return new SulfurasUpdateQualityRule(item);
                case "Conjured":
                    return new ConjuredUpdateQualityRule(item);
                default:
                    return new RegularUpdateQualityRule(item);
            }
        }
    }
}