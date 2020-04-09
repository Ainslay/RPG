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
    }
}
