namespace RPG.Character.Resources
{
    class Will : Resource
    {
        public Will(CharacterResources resourceName, int maxValue) : base(resourceName, maxValue)
        {
            CurrentValue = maxValue;
        }

        public override void Generate()
        {
            throw new System.NotImplementedException();
        }
    }
}