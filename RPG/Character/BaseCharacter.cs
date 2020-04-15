using System;

using RPG.Character.Resources;
using RPG.Character.Stats;

namespace RPG.Character
{
    abstract class BaseCharacter
    {
        protected Health Health { get; set; }
        protected Resource Resource { get; set; }
        protected Attributes Attributes;
        public Statistics Statistics;
        private bool _isAlive;
        
        public BaseCharacter()
        {
            _isAlive = true;
        }

        // Trzy sposoby na dostanie się do pól, którego powinienem używać?
        public void PrintStatus()
        {
            Console.WriteLine($"Health: {Health.CurrentValue} {Resource.Name}: {Resource.CurrentValue}");
            Console.WriteLine($"Strength: {Attributes.GetStrength().Value} Dexterity: {Attributes.GetDexterity().Value} Inteligence: {Attributes.GetIntelligence().Value}");
            Console.WriteLine($"Iniciative: {GetCurrentIniciative()} Hit chance: {Statistics.HitChance.CurrentValue}");
            Console.WriteLine($"Physical attack: {Statistics.AttackStrength.Physical} Magic attack: {Statistics.AttackStrength.Magic}");
            Console.WriteLine($"Physical resistance: {Statistics.Resistances.PhysicalResistance.CurrentValue} Magic resistance: {Statistics.Resistances.MagicResistance.CurrentValue}");
        }

        // Na bank stąd wyleci
        public void Attack(BaseCharacter target)
        {
            var damage = Statistics.AttackStrength.Physical;
            target.TakeDamage(damage);
        }

        protected void TakeDamage(int amount)
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

        public int GetCurrentIniciative()
        {
            return Statistics.Iniciative.CurrentValue;
        }

        public bool IsAlive()
        {
            return _isAlive;
        }
    }
}
