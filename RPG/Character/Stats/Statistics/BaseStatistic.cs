using RPG.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPG.Character.Stats
{
    abstract class BaseStatistic
    {
        protected int BaseValue { get; set; }
        protected int CurrentValue { get; set; }

        public BaseStatistic(BaseAttribute baseAttribute)
        {
            ParamCheck.IsNull(baseAttribute);

            BaseValue = baseAttribute.GetBaseValue();
            CurrentValue = baseAttribute.GetBaseValue();
        }

        public int GetCurrentValue()
        {
            return CurrentValue;
        }

        public int GetBaseValue()
        {
            return BaseValue;
        }
    }
}
