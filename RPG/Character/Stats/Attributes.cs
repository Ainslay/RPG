using System;
using System.Collections.Generic;
using System.Text;

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
    }
}
