using RPG.Character.Player;
using RPG.Character.Proffesions;
using System;
using Xunit;

namespace RPG.Tests.CharacterTests
{
    public class PlayerTests
    {
        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData(" ")]
        public void Given_InvalidNameParameter_When_ConstructingPlayer_Then_ThrowsArgumentException(string name)
        {
            Assert.Throws<ArgumentException>(() => new PlayerCharacter(name, new Monk()));
        }

        [Fact]
        public void Given_NullProffesionParameter_When_ConstructingPlayer_Then_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new PlayerCharacter("John", null));
        }
    }
}
