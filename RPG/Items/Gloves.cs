﻿namespace RPG.Items
{
    class Gloves : Item
    {
        public Gloves()
        { }

        public Gloves(string name, string flavorText, int bonusStrength, int bonusDexterity, int bonusIntelligence, int value, int weight) 
            : base(name, flavorText, bonusStrength, bonusDexterity, bonusIntelligence, value, weight)
        { }
    }
}
