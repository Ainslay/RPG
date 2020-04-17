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
        public void Given_NullBattle_When_ConstructingBattleResult_Then_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new BattleResult(null));
        }
    }
}
