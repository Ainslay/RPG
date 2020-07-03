using System.Collections.Generic;
using RPG.API.Model;

namespace RPG.API.IntegrationTests.Utilities
{
    static class Dummies
    {
        public static Player GetDummyPlayer()
        {
            return new Player
            {
                Id = 1,
                Name = "Tester",
                Proffesion = "Warrior",
                Health = 100,
                Resource = 1,
                Strength = 1,
                Dexterity = 1,
                Intelligence = 1,
                Level = 1,
                Items = new List<Item>()
            };
        }

        public static List<Player> GetDummyPlayers()
        {
            return new List<Player>
            {
                new Player
                {
                    Id = 1, Name = "Tester1", Proffesion = "Warrior",
                    Health = 100, Resource = 1,
                    Strength = 1, Dexterity = 1, Intelligence = 1,
                    Level = 1,
                    Items = new List<Item>()
                },
                new Player
                {
                    Id = 2, Name = "Tester2", Proffesion = "Mage",
                    Health = 100, Resource = 1,
                    Strength = 1, Dexterity = 1, Intelligence = 1,
                    Level = 1,
                    Items = new List<Item>()
                },
                new Player
                {
                    Id = 3, Name = "Tester3", Proffesion = "Monk",
                    Health = 100, Resource = 1,
                    Strength = 1, Dexterity = 1, Intelligence = 1,
                    Level = 1,
                    Items = new List<Item>()
                }
            };
        }
    }
}
