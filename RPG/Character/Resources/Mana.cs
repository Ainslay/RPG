namespace RPG.Character.Resources
{
    class Mana : Resource
    {
        public Mana(CharacterResources resourceName, int maxValue) 
            : base(resourceName, maxValue)
        {
            BaseValue = 0;
            CurrentValue = 0;
        }

        public override void Generate()
        {
            throw new System.NotImplementedException();
        }
    }
}
