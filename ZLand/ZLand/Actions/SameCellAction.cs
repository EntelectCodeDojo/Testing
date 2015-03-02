using ZLand.Actors;

namespace ZLand.Actions
{
    public abstract class SameCellAction : GameAction
    {
        protected SameCellAction(int cost, string name)
            : base(cost, name)
        {
        }

        public virtual bool CanAffordAction(Actor actor)
        {
            return actor.CurrentActionPoints >= Cost;
        }

        public abstract void Perform(Actor initiatingActor);
    }
}