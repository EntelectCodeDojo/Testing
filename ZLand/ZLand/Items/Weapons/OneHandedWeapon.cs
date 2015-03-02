using System.Collections.Generic;
using ZLand.Actions;

namespace ZLand.Items.Weapons
{
    public abstract class OneHandedWeapon: Weapon
    {
        protected OneHandedWeapon() : base(false)
        {
        }

        protected OneHandedWeapon(List<GameAction> actions) 
            : base(actions, false)
        {
        }
    }
}