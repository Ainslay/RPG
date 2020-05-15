using System;
using System.Collections.Generic;
using System.Text;
using RPG.Items;

namespace RPG.Character.Stats
{
    class Iniciative : BaseStatistic
    {
        public Iniciative(Dexterity dexterity) 
            : base(dexterity)
        { }

        public void RecalculateBaseValue(Dexterity dexterity, Equipment equipment)
        {
            BaseValue = dexterity.GetBaseValue() + equipment.GetBonusDexterity();
        }

        public void RecalculateCurrentValue(Dexterity dexterity, Equipment equipment)
        {
            CurrentValue = dexterity.GetCurrentValue() + equipment.GetBonusDexterity();
        }
    }
}
