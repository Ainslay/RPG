using System;
using Xunit;

using RPG.Character.Enemies;
using RPG.Character.Player;
using RPG.Character.Proffesions;
using RPG.Combat;

namespace RPG.Tests.CombatTests
{
    public class BattleResultTests
    {
        [Fact]
        public void Given_NullPlayer_When_ConstructingBattleResult_Then_ThrowsArgumentNullException()
        {
            var enemy = new Goblin(1, ThreatLevels.DeathMarch);

            Assert.Throws<ArgumentNullException>(() => new BattleResult(null, enemy));
        }

        [Fact]
        public void Given_NullEnemy_When_ConstructingBattleResult_Then_ThrowsArgumentNullException()
        {
            var player = PlayerFactory.Create("John", PlayerProffesions.Mage);

            Assert.Throws<ArgumentNullException>(() => new BattleResult(player, null));
        }
    }
}
