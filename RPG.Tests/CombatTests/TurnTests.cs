using System;
using Xunit;
using Moq;

using RPG.Character.Player;
using RPG.Character.Proffesions;
using RPG.Combat.Turns;

namespace RPG.Tests.CombatTests
{
    public class TurnTests
    {
        [Fact]
        public void Given_NullCharacterParameter_When_ConstructingTurn_Then_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new Turn(null));
        }

        [Fact]
        public void Given_NoParameters_When_CallingGetCharacter_Then_ReturnsCharacter()
        {
            var mockedCharacter = new Mock<PlayerCharacter>(new object[] { "John", new Mage() });
            var turn = new Turn(mockedCharacter.Object);

            var result = turn.GetCharacter();

            Assert.Equal(mockedCharacter.Object, result);
        }
    }
}
