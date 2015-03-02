namespace ZLand.Actions
{
    public abstract class GameAction
    {
        public string Name { get; set; }
        public int Cost { get; set; }

        protected GameAction(int cost, string name)
        {
            Cost = cost;
            Name = name;
        }
    }
}