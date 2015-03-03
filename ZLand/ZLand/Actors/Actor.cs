using System.Collections.Generic;
using ZLand.Actions;
using ZLand.Items.Armor;
using ZLand.Items.Weapons;
using ZLand.World;

namespace ZLand.Actors
{
    public abstract class Actor
    {
        public int ActionPointsPerTurn { get; set; }
        public int CurrentActionPoints { get; set; }
        public Health Health { get; set; }
        public Cell CurrentPosition { get; set; }
        public Weapon CurrentWeapon { get; set; }
        /// <summary>
        /// How many cells the actor can move per action point
        /// </summary>
        /// <value>
        /// The base move speed.
        /// </value>
        public int BaseMoveSpeed { get; set; }
        public Armor CurrentArmor { get; set; }
        public Stats Stats { get; set; }
        public List<GameAction> BaseActions { get; set; }

        public List<GameAction> GetAllActions()
        {
            var allActions = new List<GameAction>();
            BaseActions.AddRange(BaseActions);
            BaseActions.AddRange(CurrentWeapon.Actions);
            return allActions;
        }

        protected void EnsureHasEnoughPoints(GameAction action)
        {
            if (CurrentActionPoints < action.Cost)
            {
                throw new NotEnoughActionPointsException();
            }
        }

        protected virtual void EnsureInRange(OtherCellAction action, Cell targetCell)
        {
            if (!IsInRange(action, targetCell))
            {
                throw new NotInRangeException();
            }
        }

        public virtual bool IsInRange(OtherCellAction action, Cell targetCell)
        {
            var distance = CurrentPosition.DistanceTo(targetCell);
            return distance <= action.Range;
        }

        protected void SpendPoints(GameAction action)
        {
            EnsureHasEnoughPoints(action);
            CurrentActionPoints -= action.Cost;
        }


        public virtual void PerformAction(SameCellAction action)
        {
            SpendPoints(action);
            action.Perform(this);
        }

        public virtual void PerformAction(OtherCellAction action, Cell targetCell)
        {
            EnsureInRange(action, targetCell);
            SpendPoints(action);
            action.Perform(this, targetCell);
        }

        public virtual void TakeDamageFromAttack(AttackResult attackResult)
        {
            throw new System.NotImplementedException();
        }
    }
}