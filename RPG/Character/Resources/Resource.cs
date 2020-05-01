using RPG.Utilities;
using System;

namespace RPG.Character.Resources
{
    abstract class Resource
    {
        protected CharacterResources Name;
        protected int CurrentValue;
        protected int BaseValue;
        protected int MaxValue;

        public Resource(CharacterResources name, int maxValue)
        {
            Name = name;
            MaxValue = maxValue;
        }

        public abstract void Generate();

        public bool Spend(uint amount)
        {
            if (CurrentValue - amount >= 0)
            {
                CurrentValue -= (int)amount;
                return true;
            }
            return false;
        }

        public CharacterResources GetName()
        {
            return Name;
        }

        public int GetMaxValue()
        {
            return MaxValue;
        }

        public int GetCurrentValue()
        {
            return CurrentValue;
        }
    }
}
