using System;
using RPG.Utilities;

namespace RPG.Items
{
    abstract class Item
    {
        protected readonly string Name;
        protected readonly string FlavorText;
        protected readonly int Value;
        protected readonly int Weight;
        protected readonly int BonusStrength;
        protected readonly int BonusDexterity;
        protected readonly int BonusIntelligence;
        protected ItemTypes Type;

        public Item()
        {
            Name = "None";
        }

        public Item(string name, string flavorText, int bonusStrength, int bonusDexterity, int bonusIntelligence, int value, int weight)
        {
            ParamCheck.IsNullOrWhitespace(name);
            ParamCheck.IsNullOrWhitespace(flavorText);
            ParamCheck.IsBelowZero(bonusStrength);
            ParamCheck.IsBelowZero(bonusDexterity);
            ParamCheck.IsBelowZero(bonusIntelligence);
            ParamCheck.IsBelowZero(value);
            ParamCheck.IsBelowZero(weight);

            Name = name;
            FlavorText = flavorText;
            BonusStrength = bonusStrength;
            BonusDexterity = bonusDexterity;
            BonusIntelligence = bonusIntelligence;
            Value = value;
            Weight = weight;
        }

        public ItemTypes GetItemType()
        {
            return Type;
        }

        public string GetName()
        {
            return Name;
        }

        public string GetFlavorText()
        {
            return FlavorText;
        }

        public int GetBonusStrength()
        {
            return BonusStrength;
        }

        public int GetBonusDexterity()
        {
            return BonusDexterity;
        }

        public int GetBonusIntelligence()
        {
            return BonusIntelligence;
        }

        public int GetValue()
        {
            return Value;
        }

        public int GetWeight()
        {
            return Weight;
        }

        public virtual void PrintDetails()
        {
            Console.WriteLine(Name);
            Console.WriteLine(FlavorText);
            Console.WriteLine($"Value: {Value}\tWeight: {Weight}");
        }
    }
}
