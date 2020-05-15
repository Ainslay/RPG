using RPG.Items;

namespace RPG.Character.Stats
{
    class Dexterity : BaseAttribute
    {
        public Dexterity(int value) 
            : base(value)
        { }

        public void RecalculateBaseValue(Equipment equipment)
        {
            BaseValue = BaseValue + equipment.GetBonusDexterity();
        }

        public void RecalculateCurrentValue(Equipment equipment)
        {
            CurrentValue = BaseValue + equipment.GetBonusDexterity();
        }
    }
}
