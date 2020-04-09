namespace RPG.Character.Resources
{
    class Mana : Resource
    {
        public Mana(CharacterResources resourceName, int maxValue) 
            : base(resourceName, maxValue)
        {
            CurrentValue = 0;
        }

        public override void Generate()
        {
            throw new System.NotImplementedException();
        }
    }
}