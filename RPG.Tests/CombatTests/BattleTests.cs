using System;
using Xunit;

using RPG.Character;
using RPG.Character.Enemies;
using RPG.Character.Player;
using RPG.Character.Proffesions;
using RPG.Combat.Battles;
using Moq;

namespace RPG.Tests.CombatTests
{
    public class BattleTests
    {
        private Mock<PlayerCharacter> _mockedPlayer;
        private Mock<Slime> _mockedSlime;

        public BattleTests()
        {
            _mockedPlayer = new Mock<PlayerCharacter>(new object[] { "John", new Warrior() });
            _mockedSlime = new Mock<Slime>(new object[] { It.IsAny<int>(), It.IsAny<ThreatLevels>() });
            _mockedSlime = new Mock<Slime>(new object[] { 1, ThreatLevels.Easy });
        }

        [Fact]
        public void Given_NullPlayer_When_ConstructingBattle_Then_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new Battle(null, _mockedSlime.Object));
        }

        [Fact]
        public void Given_NullEnemy_When_ConstructingBattle_Then_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new Battle(_mockedPlayer.Object, null));
        }

        [Fact]
        public void Given_NoParameters_When_CallingGetPlayer_Then_ReturnsPlayer()
        {
            var battle = new Battle(_mockedPlayer.Object, _mockedSlime.Object);

            var result = battle.GetPlayer();

            Assert.Equal(_mockedPlayer.Object, result);
        }

        [Fact]
        public void Given_NoParameters_When_CallingGetEnemy_Then_ReturnsEnemy()
        {
            var battle = new Battle(_mockedPlayer.Object, _mockedSlime.Object);

            var result = battle.GetEnemy();

            Assert.Equal(_mockedSlime.Object, result);
        }
    }
}
