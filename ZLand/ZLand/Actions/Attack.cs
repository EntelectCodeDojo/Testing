using ZLand.DamageTypes;

namespace ZLand.Actions
{
    public abstract class Attack : OtherCellAction
    {
        protected Attack(int cost, string name, int range, double minDamage, double maxDamage, DamageType damageType, double criticalHitChance, double criticalMissChance) 
            : base(cost, name, range)
        {
            MinDamage = minDamage;
            MaxDamage = maxDamage;
            DamageType = damageType;
            CriticalHitChance = criticalHitChance;
            CriticalMissChance = criticalMissChance;
        }

        public double MinDamage { get; set; }
        public double MaxDamage { get; set; }
        public DamageType DamageType { get; set; }
        public double CriticalHitChance { get; set; }
        public double CriticalMissChance { get; set; }
    }
}