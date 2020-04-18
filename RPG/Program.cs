using System;
using System.Runtime.CompilerServices;

using RPG.Character.Enemies;
using RPG.Character.Enemies.Tools;
using RPG.Character.Player;
using RPG.Character.Proffesions;
using RPG.Combat.Battles;

[assembly: InternalsVisibleTo("RPG.Tests")]
namespace RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            var player = PlayerFactory.Create("Johnatan Joestar", PlayerProffesions.Monk);

            var enemy = EnemyFactory.Create(player.GetLevelValue(), Enemies.Slime, ThreatLevels.Easy, new StatMultiplier());

            var battle = new Battle(player, enemy);

            battle.Fight();

            Console.ReadKey();
        }
    }
}

// Plik editor.config -> ustala zasady jak formatować kod, sprawdź jak to skonfigurować

// Wprowadzić obiekt, który koordynuje rozgrywkę, jakiś StoryTeller
// 

// BATTLE RESULT
// -- ref do charactera
// -- statsy po walce
// -- ile expa 
// -- (nagrody)

// Ogarnąć jak przetrzymywać stringi żeby ich nie hardcodować

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