using System.Collections.Generic;
using ZLand.Actions;

namespace ZLand.Items.Weapons
{
    public abstract class Weapon : ActionableItem
    {
        public bool IsTwoHanded { get; set; }

        protected Weapon(bool isTwoHanded)
        {
            IsTwoHanded = isTwoHanded;
        }

        protected Weapon(List<GameAction> actions, bool isTwoHanded)
            : base(actions)
        {
            IsTwoHanded = isTwoHanded;
        }

    }
}