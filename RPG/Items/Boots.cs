﻿namespace RPG.Items
{
    class Boots : Item
    {
        public Boots()
        {
            Type = ItemTypes.Boots;
        }

        public Boots(string name, string flavorText, int bonusStrength, int bonusDexterity, int bonusIntelligence, int value, int weight) 
            : base(name, flavorText, bonusStrength, bonusDexterity, bonusIntelligence, value, weight)
        {
            Type = ItemTypes.Boots;
        }
    }
}
