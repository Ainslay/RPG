namespace RPG.Items
{
    class Armor : Item
    {
        public Armor()
        {
            Type = ItemTypes.Armor;
        }

        public Armor(string name, string flavorText, int bonusStrength, int bonusDexterity, int bonusIntelligence, int value, int weight) 
            : base(name, flavorText, bonusStrength, bonusDexterity, bonusIntelligence, value, weight)
        {
            Type = ItemTypes.Armor;
        }
    }
}
