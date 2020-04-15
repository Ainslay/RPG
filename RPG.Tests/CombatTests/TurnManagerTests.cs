using System;
using System.Collections.Generic;
using Xunit;

using RPG.Character;
using RPG.Combat;

namespace RPG.Tests.CombatTests
{
    public class TurnManagerTests
    {
        [Fact]
        public void Given_NullCollection_When_CallingBuild_Then_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => TurnManager.Build(null));
        }

        [Fact]
        public void Given_EmptyCollection_When_CallingBuild_Then_ThrowsArgumentException()
        {
            var fighters = new List<BaseCharacter>();

            Assert.Throws<ArgumentException>(() => TurnManager.Build(fighters));
        }
    }
}
