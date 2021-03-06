﻿using System;

using RPG.Character.Resources;
using RPG.Character.Stats;
using RPG.Items;

namespace RPG.Character
{
    abstract class BaseCharacter
    {
        protected string Name;
        protected Health Health;
        protected Resource Resource;
        protected Attributes Attributes;
        protected Statistics Statistics;
        protected Equipment Equipment;
        protected bool Alive;
        
        public BaseCharacter()
        {
            Equipment = new Equipment();
            Alive = true;
        }

        public virtual void PrintStatus()
        {
            Console.WriteLine($"{Name} status:");
            Console.WriteLine($"Health: {Health.GetCurrentValue()} {Resource.GetName()}: {Resource.GetCurrentValue()}");
            Console.WriteLine($"Strength: {Attributes.GetStrengthCurrentValue()} Dexterity: {Attributes.GetDexterityCurrentValue()} Inteligence: {Attributes.GetIntelligenceCurrentValue()}");
            Console.WriteLine($"Iniciative: {Statistics.GetCurrentIniciative()} Hit chance: {Statistics.GetCurrentHitChance()}");
            Console.WriteLine($"Physical attack: {Statistics.GetPhysicalAttack()} Magic attack: {Statistics.GetMagicAttack()}");
            Console.WriteLine($"Physical resistance: {Statistics.GetCurrentPhysicalResistance()} Magic resistance: {Statistics.GetCurrentMagicResistance()}");
            Console.WriteLine();
        }

        public void RecalculateBaseStats()
        {
            Health.RecalculateBaseValue(Attributes.GetStrength(), Equipment);
            Attributes.RecalculateBaseAttributes(Equipment);
            Statistics.RecalculateBaseStatistics(Attributes, Equipment);
        }

        public void RecalculateCurrentStats()
        {
            Statistics.RecalculateCurrentStatistics(Attributes, Equipment);
            Attributes.RecalculateCurrentAttributes(Equipment);
        }

        public void TakeDamage(int amount)
        {
            Health.LowerHealth(amount);
            CheckIsAlive();
        }

        public Statistics GetStatistics()
        {
            return Statistics;
        }

        public virtual int GetCurrentIniciative()
        {
            return Statistics.GetCurrentIniciative();
        }

        public bool IsAlive()
        {
            return Alive;
        }

        public string GetName()
        {
            return Name;
        }
        
        protected void CheckIsAlive()
        {
            if(Health.GetCurrentValue() == 0)
            {
                Alive = false;
            }
        }
    }
}
