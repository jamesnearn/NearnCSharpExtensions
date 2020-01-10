using System;
using NearnCSharpExtensions;
using Xunit;

namespace NearnCSharpExtensionsTests
{
    public class StringExtensionsTests
    {
        [Theory(DisplayName = "RemoveSpaces Should Succeed")]
        [InlineData("Test This Out", "TestThisOut")]
        public void RemoveSpaces_Should_Succeed(string given, string expected)
        {
            Assert.Equal(expected, given.RemoveSpaces());
        }
    }
}
