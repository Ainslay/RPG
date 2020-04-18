using System;
using Xunit;

using RPG.Character.Enemies;
using RPG.Character.Player;
using RPG.Character.Proffesions;
using RPG.Character.Enemies.Tools;

namespace RPG.Tests.CharacterTests
{
    public class RandomEnemyFactoryTests
    {
        [Fact]
        public void Given_NullStatMultiplier_When_CallingCreate_Then_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => RandomEnemyFactory.Create(4, null));
        }

        [Fact]
        public void Given_ValidParameter_When_CallingCreate_Then_ReturnsEnemy()
        {
            var player = PlayerFactory.Create("John", PlayerProffesions.Warrior);
            
            var result = RandomEnemyFactory.Create(player.GetLevelValue(), new StatMultiplier());

            Assert.NotNull(result);
        }
    }
}
