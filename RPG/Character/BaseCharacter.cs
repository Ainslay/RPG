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
        protected Statistics Statistics;
        private bool _isAlive;
        
        public BaseCharacter()
        {
            _isAlive = true;
        }

        public void PrintStatus()
        {
            Console.WriteLine($"{Name} status:");
            Console.WriteLine($"Health: {Health.GetCurrentValue()} {Resource.GetName()}: {Resource.GetCurrentValue()}");
            Console.WriteLine($"Strength: {Attributes.GetStrengthValue()} Dexterity: {Attributes.GetDexterityValue()} Inteligence: {Attributes.GetIntelligenceValue()}");
            Console.WriteLine($"Iniciative: {Statistics.GetCurrentIniciative()} Hit chance: {Statistics.GetCurrentHitChance()}");
            Console.WriteLine($"Physical attack: {Statistics.GetPhysicalAttack()} Magic attack: {Statistics.GetMagicAttack()}");
            Console.WriteLine($"Physical resistance: {Statistics.GetCurrentPhysicalResistance()} Magic resistance: {Statistics.GetCurrentMagicResistance()}");
            Console.WriteLine();
        }

        public void TakeDamage(int amount)
        {
            Health.LowerHealth(amount);
            CheckIsAlive();
        }

        protected void CheckIsAlive()
        {
            if(Health.GetCurrentValue() == 0)
            {
                _isAlive = false;
            }
        }

        public Statistics GetStatistics()
        {
            return Statistics;
        }

        public int GetCurrentIniciative()
        {
            return Statistics.GetCurrentIniciative();
        }

        public bool IsAlive()
        {
            return _isAlive;
        }
    }
}
