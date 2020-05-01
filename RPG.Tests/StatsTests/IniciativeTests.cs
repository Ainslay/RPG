using System;
using Moq;
using Xunit;

using RPG.Character.Stats;

namespace RPG.Tests.StatsTests
{
    public class IniciativeTests
    {
        [Fact]
        public void Given_NullParameter_When_ConstuctingIniciative_Then_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new Iniciative(null));
        }

        [Fact]
        public void Given_ValidParameter_When_ConstructingIniciative_Then_ConstructsIniciative()
        {
            var mockedDexterity = new Mock<Dexterity>(new object[] { It.IsAny<int>() });
            mockedDexterity.Setup(dexterity => dexterity.GetBaseValue()).Returns(5);
            var expected = 5;

            var result = new Iniciative(mockedDexterity.Object);

            Assert.Equal(expected, result.GetBaseValue());
        }
    }
}
