using System;
using RPG.Utilities;

namespace RPG.Items
{
    class Weapon : Item
    {
        private readonly int _bonusPhysicalAttack;
        private readonly int _bonusMagicAttack;

        public Weapon()
        { }

        public Weapon(string name, string flavorText, int bonusPhysicalAttack, int bonusMagicAttack, int bonusStrength, int bonusDexterity, int bonusIntelligence, int value, int weight) 
            : base(name, flavorText, bonusStrength, bonusDexterity, bonusIntelligence, value, weight)
        {
            ParamCheck.IsBelowZero(bonusPhysicalAttack);
            ParamCheck.IsBelowZero(bonusMagicAttack);

            _bonusPhysicalAttack = bonusPhysicalAttack;
            _bonusMagicAttack = bonusMagicAttack;
        }

        public int GetBonusPhysicalAttack()
        {
            return _bonusPhysicalAttack;
        }

        public int GetBonusMagicAttack()
        {
            return _bonusMagicAttack;
        }

        public override void PrintDetails()
        {
            Console.WriteLine(Name);
            Console.WriteLine($"Bonus physical attack: {_bonusPhysicalAttack}");
            Console.WriteLine($"Bonus magic attack: {_bonusMagicAttack}");
            Console.WriteLine(FlavorText);
            Console.WriteLine($"Value: {Value}\tWeight: {Weight}");
        }
    }
}
