using System;
using Xunit;
using RPG.Character.Proffesions;
using RPG.Character.Player;

namespace RPG.Tests.CharacterTests
{
    public class PlayerFactoryTests
    {
        [Fact]
        public void Given_InvalidPlayerProffesion_When_CallingCreate_Then_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => PlayerFactory.Create("Mock", PlayerProffesions.None));
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("  ")]
        public void Given_InvalidNameParameter_When_CallingCreate_Then_ThrowsArgumentException(string name)
        {
            Assert.Throws<ArgumentException>(() => PlayerFactory.Create(name, PlayerProffesions.Mage));
        }

        [Theory]
        [InlineData(PlayerProffesions.Mage)]
        [InlineData(PlayerProffesions.Warrior)]
        [InlineData(PlayerProffesions.Monk)]
        public void Given_ValidParameters_When_CallingCreate_Then_ConstructsPlayer(PlayerProffesions proffesion)
        {
            var expected = proffesion.ToString();
            
            var result = PlayerFactory.Create("John", proffesion);
            
            Assert.Equal(expected, result.Proffesion.Name);
        }
    }
}
