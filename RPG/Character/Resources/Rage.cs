namespace RPG.Character.Resources
{
    class Rage : Resource
    {
        private int _generationRate;

        public Rage(CharacterResources resourceName, int maxValue, int generationRate)
            : base(resourceName, maxValue)
        {
            BaseValue = 0;
            CurrentValue = 0;
            _generationRate = generationRate;
        }

        public override void Generate()
        {
            CurrentValue += _generationRate;

            if (CurrentValue > MaxValue)
            {
                CurrentValue = MaxValue;
            }
        }
    }
}
