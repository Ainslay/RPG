using System.Collections.Generic;
using RPG.Utilities;

namespace RPG.Items
{
    class Equipment
    {
        public Helmet Helmet { get { return Helmet; } set { ParamCheck.IsNull(value); Helmet = value; OnEquip(); } }
        public Armor Armor   { get { return Armor; }  set { ParamCheck.IsNull(value); Armor = value; OnEquip(); } }
        public Gloves Gloves { get { return Gloves; } set { ParamCheck.IsNull(value); Gloves = value; OnEquip(); } }
        public Weapon Weapon { get { return Weapon; } set { ParamCheck.IsNull(value); Weapon = value; OnEquip(); } }
        public Boots Boots   { get { return Boots; }  set { ParamCheck.IsNull(value); Boots = value; OnEquip(); } }

        private int _bonusStrength;
        private int _bonusDexterity;
        private int _bonusIntelligence;

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

        private void OnEquip()
        {
            var items = new List<Item> { Helmet, Armor, Gloves, Weapon, Boots };
            int strengthSum = 0, dexteritySum = 0, intelligenceSum = 0;

            _bonusStrength = 0;
            _bonusDexterity = 0;
            _bonusIntelligence = 0;

            items.ForEach(item =>
            {
                strengthSum += item.GetBonusStrength();
                dexteritySum += item.GetBonusDexterity();
                intelligenceSum += item.GetBonusIntelligence();
            });

            _bonusStrength = strengthSum;
            _bonusDexterity = dexteritySum;
            _bonusIntelligence = intelligenceSum;
        }
    }
}
