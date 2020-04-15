using System;
using Xunit;

using RPG.Character.Enemies;
using RPG.Character.Stats;
using RPG.Character.Player;
using RPG.Character.Proffesions;

namespace RPG.Tests.CharacterTests
{
    public class EnemyFactoryTests
    {
        [Fact]
        public void Given_NullLevelParameter_When_CallingCreate_Then_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => EnemyFactory.Create(null, Enemies.Slime, ThreatLevels.Easy));
        }

        [Fact]
        public void Given_ValidParameters_When_CallingCreate_Then_ReturnsEnemy()
        {
            var player = PlayerFactory.Create("Shepard", PlayerProffesions.Warrior);

            var result = EnemyFactory.Create(player, Enemies.UndeadMage, ThreatLevels.DeathMarch);

            Assert.Equal(Enemies.UndeadMage.ToString(), result.Name);
            Assert.Equal(ThreatLevels.DeathMarch, result.GetThreatLevel());
        }
    }
}
