using System;
using Xunit;
using Moq;

using RPG.Character.Stats;

namespace RPG.Tests.StatsTests
{
    public class PhysicalResistanceTests
    {
        [Fact]
        public void Given_NullParameter_When_ConstuctingPhysicalResistance_Then_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new PhysicalResistance(null));
        }

        [Fact]
        public void Given_ValidParameter_When_ConstructingPhysicalResistance_Then_ConstructsPhysicalResistance()
        {
            var mockedIntelligence = new Mock<Intelligence>(new object[] { It.IsAny<int>() });
            mockedIntelligence.Setup(intelligence => intelligence.GetBaseValue()).Returns(5);
            var expected = 5;

            var result = new PhysicalResistance(mockedIntelligence.Object);

            Assert.Equal(expected, result.GetBaseValue());
        }
    }
}
