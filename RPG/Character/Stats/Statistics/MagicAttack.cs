namespace RPG.Character.Stats
{
    class MagicAttack : BaseStatistic
    {
        public MagicAttack(Intelligence intelligence) 
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
