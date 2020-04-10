using RPG.Character.Stats;
using System;
using Xunit;

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
            var dexterity = new Dexterity(5);
            var expected = 5;

            var result = new Iniciative(dexterity);

            Assert.Equal(expected, result.BaseValue);
        }
    }
}
