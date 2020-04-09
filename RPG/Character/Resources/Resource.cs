using RPG.Utilities;

namespace RPG.Character.Resources
{
    abstract class Resource
    {
        public CharacterResources Name { get; protected set; }
        public int CurrentValue { get; protected set; }
        public int MaxValue { get; protected set; }

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
    }
}
