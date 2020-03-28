using System;
using System.Collections.Generic;
using System.Text;

namespace RPG.Character.Stats
{
    class Health : BaseStatistic
    {
        public Health(int baseValue, int currentValue) 
            : base(baseValue, currentValue)
        { }

        public void Calculate()
        { 
        
        }

        public void Heal(uint amount)
        {

        }

        public void TakeDamage(uint amount)
        {

        }
    }
}
