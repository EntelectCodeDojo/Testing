namespace ZLand.DamageTypes
{
    public abstract class DamageType
    {
        public string Name { get; set; }

        public static BluntForce BluntForce()
        {
            return new BluntForce();
        }
    }
}