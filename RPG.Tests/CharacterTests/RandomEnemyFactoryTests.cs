using System;
using Xunit;

using RPG.Character.Enemies;
using RPG.Character.Player;
using RPG.Character.Proffesions;
using RPG.Character.Enemies.Tools;
using Moq;

namespace RPG.Tests.CharacterTests
{
    public class RandomEnemyFactoryTests
    {
        [Fact]
        public void Given_NullStatMultiplier_When_CallingCreate_Then_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => RandomEnemyFactory.Create(It.IsAny<int>(), null));
        }

        [Fact]
        public void Given_InvalidLevel_When_CallingCreate_Then_ThrowsArgumentException()
        {
            var mockedStatMultiplier = new Mock<IStatMultiplier>();
            var invalidLevel = -1;

            Assert.Throws<ArgumentException>(() => RandomEnemyFactory.Create(invalidLevel, mockedStatMultiplier.Object));
        }

        [Fact]
        public void Given_ValidParameter_When_CallingCreate_Then_ReturnsEnemy()
        {
            var moqStatMultiplier = new Mock<IStatMultiplier>();
            moqStatMultiplier.Setup(multiplier => multiplier.Calculate(It.IsAny<int>(), It.IsAny<ThreatLevels>())).Returns(1);

            var result = RandomEnemyFactory.Create(It.IsAny<int>(), moqStatMultiplier.Object);

            Assert.NotNull(result);
            Assert.IsAssignableFrom<Enemy>(result);
        }
    }
}
