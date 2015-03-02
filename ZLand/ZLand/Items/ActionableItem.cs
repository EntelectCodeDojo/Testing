using System.Collections.Generic;
using ZLand.Actions;

namespace ZLand.Items
{
    public abstract class ActionableItem : Item
    {
        protected ActionableItem()
        {
            
        }

        protected ActionableItem(List<GameAction> actions)
        {
            Actions = actions;
        }

        public List<GameAction> Actions { get; set; }
    }
}