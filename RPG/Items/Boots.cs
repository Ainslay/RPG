namespace RPG.Items
{
    class Boots : Item
    {
        public Boots()
        { }

        public Boots(string name, string flavorText, int bonusStrength, int bonusDexterity, int bonusIntelligence, int value, int weight) 
            : base(name, flavorText, bonusStrength, bonusDexterity, bonusIntelligence, value, weight)
        { }
    }
}
