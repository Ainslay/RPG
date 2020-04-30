using System;
using Xunit;

using RPG.Character.Enemies;
using RPG.Character.Player;
using RPG.Character.Proffesions;
using RPG.Character.Enemies.Tools;
using Moq;

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
            var moqStatMultiplier = new Mock<IStatMultiplier>();
            moqStatMultiplier.Setup(multiplier => multiplier.Calculate(It.IsAny<int>(), It.IsAny<ThreatLevels>())).Returns(1);

            var result = EnemyFactory.Create(1, Enemies.UndeadMage, ThreatLevels.DeathMarch, moqStatMultiplier.Object);

            Assert.Equal(Enemies.UndeadMage.ToString(), result.GetName());
            Assert.Equal(ThreatLevels.DeathMarch, result.GetThreatLevel());
        }
    }
}
