using RPG.Character.Stats;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

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
            var intelligence = new Intelligence(5);
            var expected = 5;

            var result = new MagicResistance(intelligence);

            Assert.Equal(expected, result.GetBaseValue());
        }
    }
}
