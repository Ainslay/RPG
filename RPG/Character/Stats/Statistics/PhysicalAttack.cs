using RPG.Items;

namespace RPG.Character.Stats
{
    class PhysicalAttack : BaseStatistic
    {
        public PhysicalAttack(Strength strength) 
            : base(strength)
        { }

        public void RecalculateBaseValue(Strength  strength, Equipment equipment)
        {
            BaseValue = strength.GetBaseValue() + equipment.GetBonusStrength();
        }

        public void RecalculateCurrentValue(Strength strength, Equipment equipment)
        {
            CurrentValue = strength.GetCurrentValue() + equipment.GetBonusStrength();
        }
    }
}
