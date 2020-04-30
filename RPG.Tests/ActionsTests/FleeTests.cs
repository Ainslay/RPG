using System;
using Xunit;

using RPG.Actions;
using RPG.Character.Enemies;
using RPG.Character.Player;
using RPG.Character.Proffesions;
using RPG.Combat.Battles;
using Moq;

namespace RPG.Tests.ActionsTests
{
    public class FleeTests
    {

        private Mock<PlayerCharacter> _mockedPlayer;
        private Mock<Slime> _mockedSlime;
        private Mock<Battle> _mockedBattle;

        public FleeTests()
        {
            _mockedPlayer = new Mock<PlayerCharacter>(new object[] { "John", new Warrior() });
            _mockedSlime = new Mock<Slime>(new object[] { 1, ThreatLevels.Easy });
            _mockedBattle = new Mock<Battle>(new object[] { _mockedPlayer.Object, _mockedSlime.Object });

            _mockedBattle.Setup(battle => battle.GetEnemy()).Returns(_mockedSlime.Object);
            _mockedBattle.Setup(battle => battle.GetPlayer()).Returns(_mockedPlayer.Object);
        }

        [Fact]
        public void Given_NullParameter_When_ConstructingFlee_Then_ThrowsAgrumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new Flee(null));
        }

        [Fact]
        public void Given_NoParameters_When_CallingExecuteMultipleTimes_Then_ThrowsActionAlreadyExecutedException()
        {
            var flee = new Flee(_mockedBattle.Object);

            flee.Execute();

            Assert.Throws<ActionAlreadyExecutedException>(() => flee.Execute());
        }

        [Fact]
        public void Given_PlayerWithHigherIniciative_When_CallingExecute_Then_FleesTheBattle()
        {
            _mockedPlayer.Setup(player => player.GetCurrentIniciative()).Returns(10);
            _mockedSlime.Setup(slime => slime.GetCurrentIniciative()).Returns(5);
            var expected = true;

            var flee = new Flee(_mockedBattle.Object);
            flee.Execute();

            Assert.Equal(expected, _mockedBattle.Object.GetFled());
        }

        [Fact]
        public void Given_PlayerWithLowerIniciative_When_CallingExecute_Then_FailsToFleeTheBattle()
        {
            _mockedPlayer.Setup(player => player.GetCurrentIniciative()).Returns(5);
            _mockedSlime.Setup(slime => slime.GetCurrentIniciative()).Returns(10);
            var expected = false;

            var flee = new Flee(_mockedBattle.Object);
            flee.Execute();

            Assert.Equal(expected, _mockedBattle.Object.GetFled());
        }

        [Fact]
        public void Given_PlayerWithEqualIniciative_When_CallingExecute_Then_FailsToFleeTheBattle()
        {
            _mockedPlayer.Setup(player => player.GetCurrentIniciative()).Returns(5);
            _mockedSlime.Setup(slime => slime.GetCurrentIniciative()).Returns(5);
            var expected = false;

            var flee = new Flee(_mockedBattle.Object);
            flee.Execute();

            Assert.Equal(expected, _mockedBattle.Object.GetFled());
        }
    }
}
