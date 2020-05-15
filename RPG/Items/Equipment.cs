using System.Collections.Generic;
using RPG.Utilities;

namespace RPG.Items
{
    class Equipment
    {
        private Helmet _helmet;
        private Armor _armor;
        private Gloves _gloves;
        private Weapon _weapon;
        private Boots _boots;

        public Helmet Helmet { get { return _helmet; } set { ParamCheck.IsNull(value); _helmet = value; OnEquip(); } }
        public Armor Armor   { get { return _armor; }  set { ParamCheck.IsNull(value); _armor = value; OnEquip(); } }
        public Gloves Gloves { get { return _gloves; } set { ParamCheck.IsNull(value); _gloves = value; OnEquip(); } }
        public Weapon Weapon { get { return _weapon; } set { ParamCheck.IsNull(value); _weapon = value; OnEquip(); } }
        public Boots Boots   { get { return _boots; }  set { ParamCheck.IsNull(value); _boots = value; OnEquip(); } }

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
