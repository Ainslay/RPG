using RPG.Actions;
using RPG.Character.Enemies;
using RPG.Character.Player;
using RPG.Character.Proffesions;
using RPG.Combat;
using System;
using Xunit;

namespace RPG.Tests.ActionsTests
{
    public class FleeTests
    {
        [Fact]
        public void Given_NullParameter_When_ConstructingFlee_Then_ThrowsAgrumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new Flee(null));
        }

        [Fact]
        public void Given_NoParameters_When_CallingExecuteMultipleTimes_Then_ThrowsActionAlreadyExecutedException()
        {
            var player = PlayerFactory.Create("John", PlayerProffesions.Mage);
            var enemy = EnemyFactory.Create(player, Enemies.Slime, ThreatLevels.Easy);
            var battle = new Battle(player, enemy);

            var flee = new Flee(battle);
            flee.Perform();

            Assert.Throws<ActionAlreadyExecutedException>(() => flee.Perform());
        }

        [Fact]
        public void Given_NoParameters_When_CallingExecute_Then_FleesTheBattle()
        {
            var player = PlayerFactory.Create("John", PlayerProffesions.Monk);
            var enemy = EnemyFactory.Create(player, Enemies.Slime, ThreatLevels.Easy);
            var battle = new Battle(player, enemy);
            var expected = true;

            var flee = new Flee(battle);
            flee.Perform();

            Assert.Equal(expected, battle.GetFled());
        }
    }
}
