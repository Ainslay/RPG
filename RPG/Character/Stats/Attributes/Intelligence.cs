using RPG.Items;

namespace RPG.Character.Stats
{
    class Intelligence : BaseAttribute
    {
        public Intelligence(int value) 
            : base(value)
        { }

        public void RecalculateBaseValue(Equipment equipment)
        {
            BaseValue = BaseValue + equipment.GetBonusIntelligence();
        }

        public void RecalculateCurrentValue(Equipment equipment)
        {
            CurrentValue = BaseValue + equipment.GetBonusIntelligence();
        }
    }
}
