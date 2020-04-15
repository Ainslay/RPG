namespace RPG.Character.Stats
{
    class Attributes
    {
        private Strength _strength;
        private Dexterity _dexterity;
        private Intelligence _intelligence;

        public Attributes(int strength, int dexterity, int intelligence)
        {
            _strength = new Strength(strength);
            _dexterity = new Dexterity(dexterity);
            _intelligence = new Intelligence(intelligence);
        }

        // Dodać GetStrengthValue czy po prostu robić GetStrength().Value...

        public Strength GetStrength()
        {
            return _strength;
        }

        public Dexterity GetDexterity()
        {
            return _dexterity;
        }

        public Intelligence GetIntelligence()
        {
            return _intelligence;
        }
    }
}
