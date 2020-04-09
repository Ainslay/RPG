using System;
using System.Collections.Generic;
using System.Text;

namespace RPG.Character.Stats
{
    class Health : BaseStatistic
    {
        private int _maxValue;
        public Health(int baseValue) 
            : base(baseValue)
        {
            _maxValue = baseValue;
        }

        public void Calculate()
        { 
        
        }

        public void Heal(uint amount)
        {
            CurrentValue += (int)amount;

            if(CurrentValue > _maxValue)
            {
                CurrentValue = _maxValue;
            }
        }

        public void TakeDamage(BaseCharacter character, uint amount)
        {
            CurrentValue -= (int)amount;

            if(CurrentValue <= 0)
            {
                CurrentValue = 0;
                character.IsAlive = false;
            }
        }
    }
}
