using System;
using Xunit;

using RPG.Character.Player;
using RPG.Character.Proffesions;
using RPG.Character.Stats;

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
            var health = new Health(new Strength(5));
            int damageToTake = 10;
            var expected = health.CurrentValue - damageToTake;

            health.LowerHealth(damageToTake);

            Assert.Equal(expected, health.CurrentValue);
        }

        [Fact]
        public void Given_ValidParameter_When_CallingHeal_Then_RestoresHealth()
        {
            var health = new Health(new Strength(5));
            int amountToHeal = 10;
            health.LowerHealth(10);
            var expected = health.CurrentValue + amountToHeal;

            health.RestoreHealth(amountToHeal);

            Assert.Equal(expected, health.CurrentValue);
        }
    }
}
