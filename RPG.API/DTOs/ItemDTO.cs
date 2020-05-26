using RPG.API.Model;

namespace RPG.API.DTOs
{
    public class ItemDTO
    {
        public string Name { get; set; }
        public string FlavorText { get; set; }
        public int Value { get; set; }
        public int Weight { get; set; }
        public int BonusStrength { get; set; }
        public int BonusDexterity { get; set; }
        public int BonusIntelligence { get; set; }
        public ItemTypes Type { get; set; }

        public ItemDTO(string name, string flavorText, int value, int weight, int bonusStrength, int bonusDexterity, int bonusIntelligence, ItemTypes type)
        {
            Name = name;
            FlavorText = flavorText;
            Value = value;
            Weight = weight;
            BonusStrength = bonusStrength;
            BonusDexterity = bonusDexterity;
            BonusIntelligence = bonusIntelligence;
            Type = type;
        }
    }
}
