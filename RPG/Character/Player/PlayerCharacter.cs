using RPG.Character.Enemies;
using RPG.Character.Proffesions;
using RPG.Character.Stats;
using RPG.Utilities;
using System;

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

        public int GetLevel()
        {
            return _level.GetValue();
        }

        public void RestoreStatus()
        {
            // TODO
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
