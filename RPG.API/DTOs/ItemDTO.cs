using RPG.API.Model;

namespace RPG.API.DTOs
{
    public class ItemDTO
    {
        public string Name { get; set; }
        public string FlavorText { get; set; }
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Intelligence { get; set; }
        public ItemTypes Type { get; set; }

        public ItemDTO(string name, string flavorText, int strength, int dexterity, int intelligence, ItemTypes type)
        {
            Name = name;
            FlavorText = flavorText;
            Strength = strength;
            Dexterity = dexterity;
            Intelligence = intelligence;
            Type = type;
        }
    }
}
