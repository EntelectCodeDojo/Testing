namespace ZLand.Items.Weapons
{
    public class WeaponUsageResult
    {
        public bool CriticalHit { get; set; }
        public bool CriticalFailure { get; set; }
        public double CalculatedDamage { get; set; }
        public int ActualActionCost { get; set; }
        public double HitPercentage { get; set; }
    }
}