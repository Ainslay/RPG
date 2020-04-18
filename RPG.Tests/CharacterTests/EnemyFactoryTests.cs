using System;
using Xunit;

using RPG.Character.Enemies;
using RPG.Character.Player;
using RPG.Character.Proffesions;
using RPG.Character.Enemies.Tools;

namespace RPG.Tests.CharacterTests
{
    public class EnemyFactoryTests
    {
        [Fact]
        public void Given_NullStatMultiplier_When_CallingCreate_Then_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => EnemyFactory.Create(4, Enemies.Slime, ThreatLevels.Easy, null));
        }

        [Fact]
        public void Given_ValidParameters_When_CallingCreate_Then_ReturnsEnemy()
        {
            var player = PlayerFactory.Create("Shepard", PlayerProffesions.Warrior);

            var result = EnemyFactory.Create(player.GetLevelValue(), Enemies.UndeadMage, ThreatLevels.DeathMarch, new StatMultiplier());

            Assert.Equal(Enemies.UndeadMage.ToString(), result.Name);
            Assert.Equal(ThreatLevels.DeathMarch, result.GetThreatLevel());
        }
    }
}
