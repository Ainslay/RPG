using RPG.Character.Stats;
using System;
using Xunit;

namespace RPG.Tests.StatsTests
{
    public class HitChanceTests
    {
        [Fact]
        public void Given_NullParameter_When_ConstuctingHitChance_Then_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new HitChance(null));
        }

        [Fact]
        public void Given_ValidParameter_When_ConstructingHitChance_Then_ConstructsHitChance()
        {
            var dexterity = new Dexterity(5);
            var expected = 5;

            var result = new HitChance(dexterity);

            Assert.Equal(expected, result.GetBaseValue());
        }
    }
}
