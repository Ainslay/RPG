using RPG.Items;

namespace RPG.Character.Stats
{
    class Strength : BaseAttribute
    {
        public Strength(int value) 
            : base(value)
        { }

        public void RecalculateBaseValue(Equipment equipment)
        {
            BaseValue = BaseValue + equipment.GetBonusStrength();
        }

        public void RecalculateCurrentValue(Equipment equipment)
        {
            CurrentValue = BaseValue + equipment.GetBonusStrength();
        }
    }
}
