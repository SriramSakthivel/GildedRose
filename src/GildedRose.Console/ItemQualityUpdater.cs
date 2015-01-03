using System;
using System.Collections.Generic;
using GildedRose.Console.Rules;

namespace GildedRose.Console
{
    public class ItemQualityUpdater
    {
        private readonly IList<Item> items;
        private readonly UpdateQualityRuleFactory ruleFactory = new UpdateQualityRuleFactory();
        public ItemQualityUpdater(IList<Item> items)
        {
            if (items == null) throw new ArgumentNullException("items");
            this.items = items;
        }

        public void UpdateQuality()
        {
            foreach (Item item in items)
            {
                var rule = ruleFactory.CreateUpdateQualityRule(item);
                rule.UpdateQuality();
            }
        }
    }
}