using System;
using Moq;
using Xunit;

using RPG.Character.Stats;

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
            var mockedDexterity = new Mock<Dexterity>(new object[] { It.IsAny<int>() });
            mockedDexterity.Setup(dexterity => dexterity.GetValue()).Returns(5);
            var expected = 5;

            var result = new HitChance(mockedDexterity.Object);

            Assert.Equal(expected, result.GetBaseValue());
        }
    }
}
