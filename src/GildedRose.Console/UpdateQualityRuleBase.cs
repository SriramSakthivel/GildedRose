using System;

namespace GildedRose.Console
{
    public abstract class UpdateQualityRuleBase : IUpdateQualityRule
    {
        private readonly Item item;
        protected UpdateQualityRuleBase(Item item)
        {
            if (item == null) throw new ArgumentNullException("item");
            this.item = item;
        }

        protected Item Item
        {
            get { return item; }
        }

        public void UpdateQuality()
        {
            UpdateQualityCore();
            UpdateSellIn();
            FixQualityRange();
        }

        protected abstract void UpdateQualityCore();
        protected abstract void UpdateSellIn();
        protected abstract void FixQualityRange();
    }
}