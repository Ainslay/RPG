namespace RPG.Items
{
    class Helmet : Item
    {
        public Helmet()
        {
            Type = ItemType.Helmet;
        }

        public Helmet(string name, string flavorText, int bonusStrength, int bonusDexterity, int bonusIntelligence, int value, int weight) 
            : base(name, flavorText, bonusStrength, bonusDexterity, bonusIntelligence, value, weight)
        { 
            Type = ItemType.Helmet;
        }
    }
}
