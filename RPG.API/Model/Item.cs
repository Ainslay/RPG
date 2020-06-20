namespace RPG.API.Model
{
    public class Item
    {
        public int Id { get; set; }
        public Player Player { get; set; }
        public string Name { get; set; }
        public string FlavorText { get; set; }
        public int Value { get; set; }
        public int Weight { get; set; }
        public int BonusStrength { get; set; }
        public int BonusDexterity { get; set; }
        public int BonusIntelligence { get; set; }
        public ItemTypes Type { get; set; }

        public Item(string name, string flavorText, int value, int weight, int bonusStrength, int bonusDexterity, int bonusIntelligence, ItemTypes type)
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
