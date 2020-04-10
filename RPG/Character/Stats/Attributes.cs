namespace RPG.Character.Stats
{
    class Attributes
    {
        public Strength Strength;
        public Dexterity Dexterity;
        public Intelligence Intelligence;

        public Attributes(int strength, int dexterity, int intelligence)
        {
            Strength = new Strength(strength);
            Dexterity = new Dexterity(dexterity);
            Intelligence = new Intelligence(intelligence);
        }
    }
}
