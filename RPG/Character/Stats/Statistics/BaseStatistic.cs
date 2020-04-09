using System;
using System.Collections.Generic;
using System.Text;

namespace RPG.Character.Stats
{
    abstract class BaseStatistic
    {
        protected int BaseValue;
        protected int CurrentValue;

        public BaseStatistic(int baseValue)
        {
            BaseValue = baseValue;
            CurrentValue = baseValue;
        }
    }
}
