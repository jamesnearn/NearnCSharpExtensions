using System;
using NearnCSharpExtensions;
using Xunit;

namespace NearnCSharpExtensionsTests
{
    public class StringExtensionsTests
    {
        [Theory(DisplayName = "CountLeadingCharacters Should Succeed")]
        [InlineData("Test This Out", ' ', 0)]
        [InlineData(" Test This Out", ' ', 1)]
        [InlineData("Test This Out", 'T', 1)]
        [InlineData("", ' ', 0)]
        public void CountLeadingCharacters_Should_Succeed(string given, char characterToMatch, int expected)
        {
            Assert.Equal(expected, given.CountLeadingCharacters(characterToMatch));
        }
        
        [Theory(DisplayName = "RemoveSpaces Should Succeed")]
        [InlineData("Test This Out", "TestThisOut")]
        public void RemoveSpaces_Should_Succeed(string given, string expected)
        {
            Assert.Equal(expected, given.RemoveSpaces());
        }
    }
}
