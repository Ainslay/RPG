using RPG.Items;

namespace RPG.Character.Stats
{
    class MagicResistance : BaseStatistic
    {
        public MagicResistance(Intelligence intelligence) 
            : base(intelligence)
        { }

        public void RecalculateBaseValue(Intelligence intelligence, Equipment equipment)
        {
            BaseValue = intelligence.GetBaseValue() + equipment.GetBonusIntelligence();
        }

        public void RecalculateCurrentValue(Intelligence intelligence, Equipment equipment)
        {
            CurrentValue = intelligence.GetCurrentValue() + equipment.GetBonusIntelligence();
        }
    }
}
