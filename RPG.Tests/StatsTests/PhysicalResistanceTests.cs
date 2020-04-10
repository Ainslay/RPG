using RPG.Character.Stats;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

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
            var intelligence = new Intelligence(5);
            var expected = 5;

            var result = new PhysicalResistance(intelligence);

            Assert.Equal(expected, result.BaseValue);
        }
    }
}
