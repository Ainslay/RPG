using RPG.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPG.Character.Stats
{
    abstract class BaseStatistic
    {
        public int BaseValue { get; protected set; }
        public int CurrentValue { get; protected set; }

        public BaseStatistic(BaseAttribute baseAttribute)
        {
            ParamCheck.IsNull(baseAttribute);

            BaseValue = baseAttribute.GetValue();
            CurrentValue = baseAttribute.GetValue();
        }
    }
}
