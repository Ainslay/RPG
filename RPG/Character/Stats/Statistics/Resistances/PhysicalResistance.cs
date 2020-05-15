using System;
using System.Collections.Generic;
using System.Text;

namespace RPG.Character.Stats
{
    class PhysicalResistance : BaseStatistic
    {
        public PhysicalResistance(Intelligence intelligence) 
            : base(intelligence)
        { }

        public void RecalculateBaseValue(Intelligence intelligence)
        {
            BaseValue = intelligence.GetBaseValue();
        }

        public void RecalculateCurrentValue(Intelligence intelligence)
        {
            CurrentValue = intelligence.GetCurrentValue();
        }
    }
}
