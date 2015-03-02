using ZLand.Actors;
using ZLand.DamageTypes;
using ZLand.World;

namespace ZLand.Actions
{
    public class MeleAttack : Attack
    {
        public MeleAttack(int cost, string name, double minDamage, double maxDamage, DamageType damageType, double criticalHitChance, double criticalMissChance)
            : base(cost, name, 1, minDamage, maxDamage, damageType, criticalHitChance, criticalMissChance)
        {
        }

        public override void Perform(Actor initiatingActor, Cell targetCell)
        {
            EnsureInRange(initiatingActor, targetCell);
            EnsureHasEnoughPoints(initiatingActor, Cost);
            SpendPointsOnAction(initiatingActor, Cost);
        }

        private void SpendPointsOnAction(Actor initiatingActor, int cost)
        {
            throw new System.NotImplementedException();
        }
    }
}