using RPG.Character.Stats;
using System;
using Xunit;

namespace RPG.Tests.StatsTests
{
    public class LevelTests
    {
        [Fact]
        public void Given_ValidAmountParameter_When_CallingAddExperience_Then_AddsExperience()
        {
            var level = new Level();
            var expToGain = 20;
            var expected = 20;

            level.AddExperience(expToGain);

            Assert.Equal(expected, level.GetExperience());
        }

        [Fact]
        public void Given_InvalidAmountParameter_When_CallingAddExperience_Then_ThrowsArgumentExcpetion()
        {
            var level = new Level();
            var expToGain = -20;

            Assert.Throws<ArgumentException>(() => level.AddExperience(expToGain));
        }

        [Fact]
        public void Given_ValidAmountParameter_When_CallingSubstractExperience_Then_SubstractsExperience()
        {
            var level = new Level();
            level.AddExperience(25);
            var expToLose = 20;
            var expected = 5;

            level.SubstractExperience(expToLose);

            Assert.Equal(expected, level.GetExperience());
        }

        [Fact]
        public void Given_InvalidAmountParameter_When_CallingSubstractExperience_Then_ThrowsArgumentExcpetion()
        {
            var level = new Level();
            var expToLose = -20;

            Assert.Throws<ArgumentException>(() => level.SubstractExperience(expToLose));
        }

        [Fact]
        public void Given_TooBigAmount_When_CallingSubstractExperience_Then_ExperienceEqualsZero()
        {
            var level = new Level();
            level.AddExperience(25);
            var expToLose = 60;
            var expected = 0;

            level.SubstractExperience(expToLose);

            Assert.Equal(expected, level.GetExperience());
        }
    }
}
