﻿using System;
using System.Runtime.CompilerServices;

using RPG.Character.Enemies;
using RPG.Character.Player;
using RPG.Character.Proffesions;
using RPG.Combat;

// !!!!!!!!
// POKAZAĆ JAK SIĘ COFA COMMITA!!!!
// !!!!!!!!
[assembly: InternalsVisibleTo("RPG.Tests")]
namespace RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            var player = PlayerFactory.Create("Johnatan Joestar", PlayerProffesions.Warrior);
            
            var enemy = EnemyFactory.Create(player, Enemies.Slime, ThreatLevels.Medium);

            var battle = new Battle(player, enemy);

            battle.Fight();

            Console.ReadKey();
        }
    }
}

// BATTLE RESULT
// -- ref do charactera
// -- statsy po walce
// -- ile expa 
// -- (nagrody)

// Jak poprawić walkę żeby była bardziej rozszerzalna, lepsza do konfiguracji
// Zastanowić się nad akcjami interfejsy, klasy bazowe np. IAction
// Każda akcja może się wykonać

// PLAN!
// Utworzenie postaci       -- podstawowe tworzenie skończone
// Utworzenie przeciwnika
// Utworzenie walki
// Określ wygranego walki
// Utworzenie umiejetsnoci
// Utworzenie ekwipunku
// Historia
// Interakcja z ekwipunkiem