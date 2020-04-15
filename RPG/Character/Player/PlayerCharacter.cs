using RPG.Character.Enemies;
using RPG.Character.Proffesions;
using RPG.Character.Stats;
using RPG.Utilities;
using System;

namespace RPG.Character.Player
{
    // Tutaj przekazywanie tej profesji trochę mi nie pasi, w tym sensie że
    // mam PlayerFactory, które ładnie mi tworzy na podstawie enuma, a tutaj
    // umożliwiam przesłanie jakiejś profesji.

    class PlayerCharacter : BaseCharacter
    {
        public readonly string Name;
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
            return _level.Value;
        }

        public void RestoreStatus()
        {
            // TODO
        }

        // Takie obudowywanie wydaje mi się nie w porządku, chociaż robiliśmy coś takiego wcześniej 
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
