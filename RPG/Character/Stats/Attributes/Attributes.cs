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

        public int GetStrengthValue()
        {
            return _strength.GetBaseValue();
        }

        public int GetDexterityValue()
        {
            return _dexterity.GetBaseValue();
        }

        public int GetIntelligenceValue()
        {
            return _intelligence.GetBaseValue();
        }
    }
}
