using System;
using System.Collections.Generic;
using RPG.Utilities;
using System.Reflection;
namespace RPG.Items
{
    class Equipment
    {
        private Helmet _helmet;
        private Armor _armor;
        private Gloves _gloves;
        private Weapon _weapon;
        private Boots _boots;

        private int _bonusStrength;
        private int _bonusDexterity;
        private int _bonusIntelligence;

        public Equipment()
        {
            _helmet = new Helmet();
            _armor = new Armor();
            _gloves = new Gloves();
            _weapon = new Weapon();
            _boots = new Boots();
        }

        public void Equip(Item item)
        {
            ParamCheck.IsNull(item);

            switch (item.GetItemType())
            {
                case ItemType.Helmet:
                    _helmet = (Helmet)item;
                    break;
                case ItemType.Armor:
                    _armor = (Armor)item;
                    break;
                case ItemType.Gloves:
                    _gloves = (Gloves)item;
                    break;
                case ItemType.Weapon:
                    _weapon = (Weapon)item;
                    break;
                case ItemType.Boots:
                    _boots = (Boots)item;
                    break;
                case ItemType.None:
                default:
                    throw new Exception("Invalid item type");
            }

            OnEquip();
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

        public void Print()
        {
            var items = new List<Item> { _helmet, _armor, _gloves, _weapon, _boots };

            foreach (var item in items)
            {
                if(item.GetName() != "None")
                {
                    Console.WriteLine($"{item.GetItemType()}:");
                    item.PrintDetails();
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine($"{item.GetItemType()}: None");
                    Console.WriteLine();
                }
            }
        }

        private void OnEquip()
        {
            var items = new List<Item> { _helmet, _armor, _gloves, _weapon, _boots };
            int strengthSum = 0, dexteritySum = 0, intelligenceSum = 0;

            _bonusStrength = 0;
            _bonusDexterity = 0;
            _bonusIntelligence = 0;

            items.ForEach(item =>
            {
                if(item != null)
                {
                    strengthSum += item.GetBonusStrength();
                    dexteritySum += item.GetBonusDexterity();
                    intelligenceSum += item.GetBonusIntelligence();
                }
            });

            _bonusStrength = strengthSum;
            _bonusDexterity = dexteritySum;
            _bonusIntelligence = intelligenceSum;
        }
    }
}
