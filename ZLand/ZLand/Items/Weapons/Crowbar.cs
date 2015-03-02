using ZLand.Actions;
using ZLand.DamageTypes;

namespace ZLand.Items.Weapons
{
    public class Crowbar : OneHandedWeapon
    {
        public Crowbar()
        {
            Actions.Add(new MeleAttack(1, "Swing", 1, 3, DamageType.BluntForce(), 0.05, 0.05));
            Actions.Add(new MeleAttack(2, "Powerful Swing", 2, 8, DamageType.BluntForce(), 0.07, 0.09));
        }
    }
}