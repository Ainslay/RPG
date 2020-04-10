using RPG.Character.Stats;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace RPG.Tests.StatsTests
{
    public class ResistancesTests
    {
        [Fact]
        public void Given_NullParameter_When_ConstructingResistances_Then_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new Resistances(null));
        }
    }
}
