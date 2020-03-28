using System;
using System.Collections.Generic;
using System.Text;

using RPG.Character.Stats;

namespace RPG.Character
{
    class BaseEntity
    {
        private readonly string _name;
        private Level _level;
        private Health _health;
        private Resource _resource;
        private Attributes _attributes;
        private Resistances _resistances;
        private AttackStrength _attackStrength;
        private Iniciative _iniciative;
        private HitChance _hitChance;

        public BaseEntity(string name)
        {

        }
    }
}
