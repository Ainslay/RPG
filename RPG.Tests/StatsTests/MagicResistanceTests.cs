using System;
using Xunit;
using Moq;

using RPG.Character.Stats;

namespace RPG.Tests.StatsTests
{
    public class MagicResistanceTests
    {
        [Fact]
        public void Given_NullParameter_When_ConstuctingMagicResistance_Then_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new MagicResistance(null));
        }

        [Fact]
        public void Given_ValidParameter_When_ConstructingMagicResistance_Then_ConstructsMagicResistance()
        {
            var mockedIntelligence = new Mock<Intelligence>(new object[] { It.IsAny<int>() });
            mockedIntelligence.Setup(intelligence => intelligence.GetBaseValue()).Returns(5);
            var expected = 5;

            var result = new MagicResistance(mockedIntelligence.Object);

            Assert.Equal(expected, result.GetBaseValue());
        }
    }
}
