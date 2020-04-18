using System;
using Xunit;

using RPG.Character.Player;
using RPG.Character.Proffesions;
using RPG.Combat.Turns;

namespace RPG.Tests.CombatTests
{
    public class TurnTests
    {
        [Fact]
        public void Given_NullParameter_When_ConstructingTurn_Then_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new Turn(null));
        }

        [Fact]
        public void Given_NoParameters_When_CallingGetCharacter_Then_ReturnsCharacter()
        { 
            var character = PlayerFactory.Create("John", PlayerProffesions.Mage);
            var turn = new Turn(character);

            var result = turn.GetCharacter();

            Assert.Equal(character, result);
        }
    }
}
