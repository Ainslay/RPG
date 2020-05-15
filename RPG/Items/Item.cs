using System;
using RPG.Utilities;

namespace RPG.Items
{
    abstract class Item
    {
        private string _name;
        private string _flavorText;
        private int _value;
        private int _weight;

        private int _bonusStrength;
        private int _bonusDexterity;
        private int _bonusIntelligence;

        public Item(string name, string flavorText, int bonusStrength, int bonusDexterity, int bonusIntelligence, int value, int weight)
        {
            ParamCheck.IsNullOrWhitespace(name);
            ParamCheck.IsNullOrWhitespace(flavorText);
            ParamCheck.IsBelowZero(bonusStrength);
            ParamCheck.IsBelowZero(bonusDexterity);
            ParamCheck.IsBelowZero(bonusIntelligence);
            ParamCheck.IsBelowZero(value);
            ParamCheck.IsBelowZero(weight);

            _name = name;
            _flavorText = flavorText;
            _bonusStrength = bonusStrength;
            _bonusDexterity = bonusDexterity;
            _bonusIntelligence = bonusIntelligence;
            _value = value;
            _weight = weight;
        }

        public string GetName()
        {
            return _name;
        }

        public string GetFlavorText()
        {
            return _flavorText;
        }

        public int GetBonusStrength()
        {
            return _bonusStrength;
        }

        public int GetBonusDexterity()
        {
            return _bonusDexterity;
        }

        public int GetBonusIntelligence()
        {
            return _bonusIntelligence;
        }

        public int GetValue()
        {
            return _value;
        }

        public int GetWeight()
        {
            return _weight;
        }

        public void PrintDetails()
        {
            Console.WriteLine(_name);
            Console.WriteLine(_flavorText);
            Console.WriteLine($"Value: {_value}\tWeight: {_weight}");
        }
    }
}
