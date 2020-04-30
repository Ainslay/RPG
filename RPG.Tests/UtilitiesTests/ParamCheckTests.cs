using System;
using System.Collections.Generic;
using Xunit;

using RPG.Utilities;

namespace RPG.Tests.UtilitiesTests
{
    public class ParamCheckTests
    {
        [Theory]
        [InlineData(null)]
        [InlineData(" ")]
        public void Given_NullOrWhitespaceString_When_CallingIsNullOrWhitespace_Then_ThrowsArgumentException(string str)
        {
            Assert.Throws<ArgumentException>(() => ParamCheck.IsNullOrWhitespace(str));
        }

        [Fact]
        public void Given_NullParameter_When_CallingIsNull_Then_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => ParamCheck.IsNull(null));
        }

        [Fact]
        public void Given_NullCollection_When_CallingIsNullOrEmpty_Them_ThrowsArgumentNullException()
        {
            List<int> list = null;
            Assert.Throws<ArgumentNullException>(() => ParamCheck.IsNullOrEmpty(list));
        }

        [Fact]
        public void Given_EmptyCollection_When_CallingIsNullOrEmpty_Them_ThrowsArgumentException()
        {
            var list = new List<int>();
            Assert.Throws<ArgumentException>(() => ParamCheck.IsNullOrEmpty(list));
        }

        [Fact]
        public void Given_IntValueBelowZero_When_CallingIsBelowZero_Then_ThrowsException()
        {
            int value = -1;
            Assert.Throws<Exception>(() => ParamCheck.IsBelowZero(value));
        }

        [Fact]
        public void Given_DoubleValueBelowZero_When_CallingIsBelowZero_Then_ThrowsException()
        {
            double value = -1.0;
            Assert.Throws<Exception>(() => ParamCheck.IsBelowZero(value));
        }

        [Fact]
        public void Given_FloatValueBelowZero_When_CallingIsBelowZero_Then_ThrowsException()
        {
            float value = -1.0f;
            Assert.Throws<Exception>(() => ParamCheck.IsBelowZero(value));
        }
    }
}
