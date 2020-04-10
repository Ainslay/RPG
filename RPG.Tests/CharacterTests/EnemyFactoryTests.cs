using System;
using Xunit;
using RPG.Character.Enemies;
using RPG.Character.Stats;

namespace RPG.Tests.CharacterTests
{
    public class EnemyFactoryTests
    {
        [Fact]
        public void Given_NullParameter_When_CallingCreate_Then_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => EnemyFactory.Create(null));
        }

        [Fact]
        public void Given_ValidParameter_When_CallingCreate_Then_ReturnsEnemy()
        {
            var level = new Level();
            
            var result = EnemyFactory.Create(level);

            Assert.NotNull(result);
        }
    }
}
