using System;
using Xunit;

using RPG.Character.Stats;
using Moq;

namespace RPG.Tests.StatsTests
{
    public class HealthTests
    {
        [Fact]
        public void Given_NullParameter_When_ConstructingHealth_Then_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new Health(null));
        }

        [Fact]
        public void Given_ValidParameter_When_CallingSubstractHealth_Then_LowersHealth()
        {
            var mockedHealth = new Mock<Health>(new object[] { new Strength(5) });
            int damageToTake = 10;
            var expected = mockedHealth.Object.GetCurrentValue() - damageToTake;

            mockedHealth.Object.LowerHealth(damageToTake);

            Assert.Equal(expected, mockedHealth.Object.GetCurrentValue());
        }

        [Fact]
        public void Given_ValidParameter_When_CallingHeal_Then_RestoresHealth()
        {
            var mockedHealth = new Mock<Health>(new object[] { new Strength(5) });
            int amountToHeal = 10;
            mockedHealth.Object.LowerHealth(10);
            var expected = mockedHealth.Object.GetCurrentValue() + amountToHeal;

            mockedHealth.Object.RestoreHealth(amountToHeal);

            Assert.Equal(expected, mockedHealth.Object.GetCurrentValue());
        }
    }
}
