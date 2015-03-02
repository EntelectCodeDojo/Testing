using ZLand.Actors;
using ZLand.World;

namespace ZLand.Actions
{
    public abstract class OtherCellAction : GameAction
    {
        protected OtherCellAction(int cost, string name, int range)
            : base(cost, name)
        {
            Range = range;
        }

        public int Range { get; set; }

        public abstract void Perform(Actor initiatingActor, Cell targetCell);

        protected virtual void EnsureInRange(Actor initiatingActor, Cell targetCell)
        {
            if (!IsInRange(initiatingActor, targetCell))
            {
                throw new NotInRangeException();
            }
        }

        protected void EnsureHasEnoughPoints(Actor initiatingActor, int pointsCost)
        {
            if (initiatingActor.CurrentActionPoints < pointsCost)
            {
                throw new NotEnoughActionPointsException();
            }
        }

        public virtual bool IsInRange(Actor actor, Cell targetCell)
        {
            return IsInRange(actor.CurrentPosition, targetCell);
        }

        public virtual bool IsInRange(Cell initiatingActorsCell, Cell targetCell)
        {
            var distance = initiatingActorsCell.DistanceTo(targetCell);
            return distance <= Range;
        }

    }
}