using System;
using Xunit;

using RPG.Character;
using RPG.Character.Enemies;
using RPG.Combat;
using RPG.Character.Player;
using RPG.Character.Proffesions;

namespace RPG.Tests.CombatTests
{
    public class BattleTests
    {
        [Fact]
        public void Given_NullPlayer_When_ConstructingBattle_Then_ThrowsArgumentNullException()
        {
            var enemy = new Goblin(1, ThreatLevels.DeathMarch);

            Assert.Throws<ArgumentNullException>(() => new Battle(null, enemy));
        }

        [Fact]
        public void Given_NullEnemy_When_ConstructingBattle_Then_ThrowsArgumentNullException()
        {
            var player = PlayerFactory.Create("John", PlayerProffesions.Mage);

            Assert.Throws<ArgumentNullException>(() => new Battle(player, null));
        }
    }
}
