namespace RPG.Character.Stats
{
    class PhysicalAttack : BaseStatistic
    {
        public PhysicalAttack(Strength strength) 
            : base(strength)
        { }

        public void RecalculateBaseValue(Strength  strength)
        {
            BaseValue = strength.GetBaseValue();
        }

        public void RecalculateCurrentValue(Strength strength)
        {
            CurrentValue = strength.GetCurrentValue();
        }
    }
}
