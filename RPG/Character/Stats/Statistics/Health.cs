using RPG.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPG.Character.Stats
{
    // Zastanawiam się czy Health na pewno powinno dziedziczyć z BaseStatistic, może powinna być standalone?

    class Health : BaseStatistic
    {
        private int _maxValue;
        public Health(Strength strength)
            : base(strength)
        {
            ParamCheck.IsNull(strength);

            _maxValue = strength.Value * 10;
            BaseValue = _maxValue;
            CurrentValue = _maxValue;
        }

        // Nie jestem pewien czy tą funkcjonalność powinno udostępniać zdorwie czy raczej postać
        public void Heal(uint amount)
        {
            CurrentValue += (int)amount;

            if(CurrentValue > _maxValue)
            {
                CurrentValue = _maxValue;
            }
        }

        public void TakeDamage(uint amount)
        {
            CurrentValue -= (int)amount;

            if(CurrentValue <= 0)
            {
                CurrentValue = 0;
            }
        }
    }
}
