using RPG.Character.Enemies;
using RPG.Character.Proffesions;
using RPG.Character.Stats;
using RPG.Utilities;
using System;
using System.Collections.Generic;

namespace RPG.Character.Player
{
    class PlayerCharacter : BaseCharacter
    {
        public Proffesion Proffesion { get; private set; }
        private Level _level;
        
        public PlayerCharacter(string name, Proffesion proffesion)
        {
            ParamCheck.IsNullOrWhitespace(name);
            ParamCheck.IsNull(proffesion);

            Name = name;
            Proffesion = proffesion;
            Resource = proffesion.Resource;
            Attributes = proffesion.BaseAttributes;
            Health = new Health(Attributes.GetStrength());
            _level = new Level();
            Statistics = new Statistics(Attributes);
        }

        public virtual int GetLevelValue()
        {
            return _level.GetValue();
        }

        public void RestoreStatus()
        {
            var restorableStats = new List<IRestorable> { Health, Resource, Attributes, Statistics };

            foreach (var stat in restorableStats)
            {
                stat.RestoreBaseValue();
            }

            Alive = true;
        }

        public void AddExperience(int amount)
        {
            _level.AddExperience(amount);
        }

        public void SubstractExperience(int amount)
        {
            _level.SubstractExperience(amount);
        }
    }
}
