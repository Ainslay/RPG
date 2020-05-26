namespace RPG.Items
{
    class Gloves : Item
    {
        public Gloves()
        { 
            Type = ItemTypes.Gloves;
        }

        public Gloves(string name, string flavorText, int bonusStrength, int bonusDexterity, int bonusIntelligence, int value, int weight) 
            : base(name, flavorText, bonusStrength, bonusDexterity, bonusIntelligence, value, weight)
        {
            Type = ItemTypes.Gloves;
        }
    }
}
