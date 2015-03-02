namespace ZLand.Items
{
    public abstract class Item
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Durability { get; set; }
        public double BaseValue { get; set; }

        public virtual double GetCurrentValue()
        {
            return BaseValue * Durability;
        }
    }
}