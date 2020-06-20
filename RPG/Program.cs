using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("RPG.Tests")]
[assembly: InternalsVisibleTo("DynamicProxyGenAssembly2")]
namespace RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            //var cardinal = new Cardinal();
            //cardinal.Supervise();
            string[] names = { "Ola", "Daniel", "Dawid", "Jakub", "Mikołaj",
                               "Kamil", "Karol", "Jarek", "Przemek", "Bartek",
                               "Kasia", "Basia", "Ezekiel", "Andrzej", "Jan" };

            var lower = names.Select(n => n.ToLower());

            //var moreThanFour = names.Where(n => n.Length > 4).Select(n => n.ToUpper()).Select(n => new { Name = n });
            //moreThanFour.FirstOrDefault();
            
            names.Where(n => n.Length == names.Min(n2 => n2.Length)).ToList().OrderBy(n => n.Length);

            var page = GetPage(names, 4);

            foreach (var item in lower)
            {
                System.Console.WriteLine(item);
            }

            Console.ReadKey();
        }

        static List<string> GetPage(string[] names, int number)
        {
            if (number < 0)
            {
                throw new Exception();
            }

            return names.Skip(number * 5).Take(5).ToList();
        }
    }
}

// Interfejs dla atrybutu i użyć w testach
// Użyć IStatMultiplier w testach
// Wprowadzić obiekt, który koordynuje rozgrywkę, jakiś StoryTeller

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
