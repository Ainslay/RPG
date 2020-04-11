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

            BaseValue = strength.Value * 10;
            CurrentValue = BaseValue;
        }

        // Nie jestem pewien czy tą funkcjonalność powinno udostępniać zdorwie czy raczej postać
        public void RestoreHealth(int amount)
        {
            CurrentValue += amount;

            if(CurrentValue > BaseValue)
            {
                CurrentValue = BaseValue;
            }
        }

        public void SubstractHealth(int amount)
        {
            CurrentValue -= amount;

            if(CurrentValue <= 0)
            {
                CurrentValue = 0;
            }
        }
    }
}
