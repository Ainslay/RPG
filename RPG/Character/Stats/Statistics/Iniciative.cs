﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RPG.Character.Stats
{
    class Iniciative : BaseStatistic
    {
        public Iniciative(Dexterity dexterity) 
            : base(dexterity)
        { }

        public void RecalculateBaseValue(Dexterity dexterity)
        {
            BaseValue = dexterity.GetBaseValue();
        }

        public void RecalculateCurrentValue(Dexterity dexterity)
        {
            CurrentValue = dexterity.GetCurrentValue();
        }
    }
}
