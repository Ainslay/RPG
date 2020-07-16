using RPG.API.Model;

namespace RPG.API.DTOs
{
    public class PlayerDTO
    {
        public string Name { get; set; }
        public Proffesions Proffesion { get; set; }
        public int Level { get; set; }
        public int Experience { get; set; }
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Intelligence { get; set; }

        public PlayerDTO(string name, Proffesions proffesion, int level, int experience,
            int strength, int dexterity, int intelligence)
        {
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
