using System;

using RPG.Character.Resources;
using RPG.Character.Stats;

namespace RPG.Character
{
    abstract class BaseCharacter
    {
        public string Name { get; protected set; }
        protected Health Health { get; set; }
        protected Resource Resource { get; set; }
        protected Attributes Attributes;
        protected Statistics _statistics;
        private bool _isAlive;
        
        public BaseCharacter()
        {
            _isAlive = true;
        }

        // Trzy sposoby na dostanie się do pól, którego powinienem używać?
        public void PrintStatus()
        {
            Console.WriteLine($"{Name} status:");
            Console.WriteLine($"Health: {Health.CurrentValue} {Resource.Name}: {Resource.CurrentValue}");
            Console.WriteLine($"Strength: {Attributes.GetStrength().Value} Dexterity: {Attributes.GetDexterity().Value} Inteligence: {Attributes.GetIntelligence().Value}");
            Console.WriteLine($"Iniciative: {GetCurrentIniciative()} Hit chance: {_statistics.HitChance.CurrentValue}");
            Console.WriteLine($"Physical attack: {_statistics.AttackStrength.Physical} Magic attack: {_statistics.AttackStrength.Magic}");
            Console.WriteLine($"Physical resistance: {_statistics.Resistances.PhysicalResistance.CurrentValue} Magic resistance: {_statistics.Resistances.MagicResistance.CurrentValue}");
            Console.WriteLine();
        }

        public void TakeDamage(int amount)
        {
            Health.LowerHealth(amount);
            CheckIsAlive();
        }

        protected void CheckIsAlive()
        {
            if(Health.CurrentValue == 0)
            {
                _isAlive = false;
            }
        }

        public Statistics GetStatistics()
        {
            return _statistics;
        }

        public int GetCurrentIniciative()
        {
            return _statistics.Iniciative.CurrentValue;
        }

        public bool IsAlive()
        {
            return _isAlive;
        }
    }
}
