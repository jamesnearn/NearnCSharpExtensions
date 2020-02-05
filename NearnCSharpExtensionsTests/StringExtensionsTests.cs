using NearnCSharpExtensions;
using Xunit;

namespace NearnCSharpExtensionsTests
{
    public class StringExtensionsTests
    {
        [Theory(DisplayName = "IndexOfAnyNot Should Succeed")]
        [InlineData("Test This Out", " ", 0)]
        [InlineData(" Test This Out", " ", 1)]
        [InlineData("Test This Out", "T", 1)]
        [InlineData("", " ", -1)]

        [InlineData("Test \nThis Out", " \n", 0)]
        [InlineData("Test \nThis Out", "\n ", 0)]

        [InlineData("Test \nThis Out", "T\n ", 1)]
        [InlineData("Test \nThis Out", "\nT ", 1)]
        [InlineData("Test \nThis Out", "\n T", 1)]

        [InlineData(" \nTest This Out", " \n", 2)]
        [InlineData(" \nTest This Out", "\n ", 2)]

        [InlineData(" \nTest This Out", "x", 0)]
        [InlineData(" \nTest This Out", "xxx", 0)]
        public void IndexOfAnyNot_Should_Succeed(string given, string charArrayToNotMatch, int expected)
        {
            Assert.Equal(expected, given.IndexOfAnyNot(charArrayToNotMatch.ToCharArray()));
        }

        [Theory(DisplayName = "IndexOfNot Should Succeed")]
        [InlineData("Test This Out", ' ', 0)]
        [InlineData(" Test This Out", ' ', 1)]
        [InlineData("Test This Out", 'T', 1)]
        [InlineData("", ' ', -1)]
        public void IndexOfNot_Should_Succeed(string given, char characterToNotMatch, int expected)
        {
            Assert.Equal(expected, given.IndexOfNot(characterToNotMatch));
        }

        [Theory(DisplayName = "RemoveSpaces Should Succeed")]
        [InlineData("Test This Out", "TestThisOut")]
        public void RemoveSpaces_Should_Succeed(string given, string expected)
        {
            Assert.Equal(expected, given.RemoveSpaces());
        }
    }
}
