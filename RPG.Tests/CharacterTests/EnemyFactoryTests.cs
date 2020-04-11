using System;
using Xunit;

using RPG.Character.Enemies;
using RPG.Character.Stats;

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
            var level = new Level();

            var result = EnemyFactory.Create(level, Enemies.UndeadMage, ThreatLevels.DeathMarch);

            Assert.Equal(Enemies.UndeadMage.ToString(), result.Name);
            Assert.Equal(ThreatLevels.DeathMarch, result.ThreatLevel);
        }
    }
}
