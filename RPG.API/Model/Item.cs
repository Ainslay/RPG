using System.Collections.Generic;

namespace RPG.API.Model
{
    public class Item
    {
        public int ItemId { get; set; }
        public string Name { get; set; }
        public string FlavorText { get; set; }
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Intelligence { get; set; }
        public ItemTypes Type { get; set; }
        public ICollection<PlayerItem> PlayerItems { get; set; }

        public Item(string name, string flavorText, int strength, int dexterity, int intelligence, ItemTypes type)
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
