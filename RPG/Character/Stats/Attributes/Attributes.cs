using System;

namespace RPG.Character.Stats
{
    class Attributes : IRestorable
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

        public void Increase(AttributesEnum attribute)
        {
            switch (attribute)
            {
                case AttributesEnum.Strength:
                    _strength.Increase();
                    break;
                case AttributesEnum.Dexterity:
                    _dexterity.Increase();
                    break;
                case AttributesEnum.Intelligence:
                    _intelligence.Increase();
                    break;
                case AttributesEnum.None:
                default:
                    throw new Exception("Invalid attribute.");
            }
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

        public void RestoreBaseValue()
        {
            _strength.RestoreBaseValue();
            _dexterity.RestoreBaseValue();
            _intelligence.RestoreBaseValue();
        }
    }
}
