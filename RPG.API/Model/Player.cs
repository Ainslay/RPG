using System;
using System.Collections.Generic;

namespace RPG.API.Model
{
    public class Player
    {
        public int Id { get; set; }
        public Guid PlayerId { get; set; }
        public string Name { get; set; }
        public Proffesions Proffesion { get; set; }
        public int Level { get; set; }
        public int Experience { get; set; }
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Intelligence { get; set; }
        public ICollection<PlayerItem> Items { get; set; }

        public Player(string name, Proffesions proffesion, int level, int experience,
            int strength, int dexterity, int intelligence)
        {
            PlayerId = Guid.NewGuid();
            Name = name;
            Proffesion = proffesion;
            Level = level;
            Experience = experience;
            Strength = strength;
            Dexterity = dexterity;
            Intelligence = intelligence;
        }
    }
}
