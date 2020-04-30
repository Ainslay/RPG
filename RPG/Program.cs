using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("RPG.Tests")]
[assembly: InternalsVisibleTo("DynamicProxyGenAssembly2")]
namespace RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            var cardinal = new Cardinal();
            cardinal.Supervise();
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
