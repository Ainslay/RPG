namespace RPG.Items
{
    class Gloves : Item
    {
        public Gloves()
        { 
            Type = ItemType.Gloves;
        }

        public Gloves(string name, string flavorText, int bonusStrength, int bonusDexterity, int bonusIntelligence, int value, int weight) 
            : base(name, flavorText, bonusStrength, bonusDexterity, bonusIntelligence, value, weight)
        {
            Type = ItemType.Gloves;
        }
    }
}
