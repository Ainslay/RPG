using System;
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
            var player = PlayerFactory.Create("Johnatan Joestar", PlayerProffesions.Monk);

            var enemy = EnemyFactory.Create(player.Level);

            var battle = new Battle(player);

            battle.Fight();

            Console.ReadKey();
        }
    }
}

// Klasy do tworzenia obiektów -> Factory
// var player = PlayerFactory.Create("Name", profesja); 

// ENUM do wyboru profesji itp.

// PLAN!
// Utworzenie postaci       -- podstawowe tworzenie skończone
// Utworzenie przeciwnika
// Utworzenie walki
// UTworzenie umiejetsnoci
// Utworzenie ekwipunku
// Historia
// Interakcja z ekwipunkiem