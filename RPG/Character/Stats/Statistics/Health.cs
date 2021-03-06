﻿using RPG.Items;
using RPG.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPG.Character.Stats
{
    class Health : BaseStatistic
    {
        public Health(Strength strength)
            : base(strength)
        {
            ParamCheck.IsNull(strength);

            BaseValue = strength.GetBaseValue() * 2;
            CurrentValue = BaseValue;
        }

        public void RestoreHealth(int amount)
        {
            CurrentValue += amount;

            if(CurrentValue > BaseValue)
            {
                CurrentValue = BaseValue;
            }
        }

        public void LowerHealth(int amount)
        {
            CurrentValue -= amount;

            if(CurrentValue <= 0)
            {
                CurrentValue = 0;
            }
        }

        public void RecalculateBaseValue(Strength strength, Equipment equipment)
        {
            BaseValue = strength.GetBaseValue() * 2 + equipment.GetBonusStrength();
        }
    }
}
