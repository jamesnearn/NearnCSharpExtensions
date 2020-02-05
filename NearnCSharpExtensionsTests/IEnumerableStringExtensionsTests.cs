using System;
using System.Collections.Generic;
using System.Linq;
using NearnCSharpExtensions;
using Xunit;

namespace NearnCSharpExtensionsTests
{
    public class IEnumerableStringExtensionsTests
    {
        [Fact(DisplayName = "IndexOfAnyNotOnEach Should Succeed With Equal Leading Whitespace")]
        public void IndexOfAnyNotOnEach_Should_Succeed_With_Equal_Leading_Whitespace()
        {
            var given = new List<string>
            {
                "   three leading spaces",
                "  two leading spaces",
                "    four leading spaces"
            };

            var expected = new List<int> { 4, 3, 5 };

            Assert.Equal(expected, given.IndexOfAnyNotOnEach(" tf".ToCharArray()));
        }

        [Fact(DisplayName = "IndexOfNotOnEach Should Succeed With Equal Leading Whitespace")]
        public void IndexOfNotOnEach_Should_Succeed_With_Equal_Leading_Whitespace()
        {
            var given = new List<string>
            {
                "   three leading spaces",
                "  two leading spaces",
                "    four leading spaces"
            };

            var expected = new List<int> { 3, 2, 4 };

            Assert.Equal(expected, given.IndexOfNotOnEach(' '));
        }

        [Fact(DisplayName = "SubstringOnEach Should Succeed")]
        public void SubstringOnEach_Should_Succeed()
        {
            var given = new List<string>
            {
                "three leading spaces",
                "two leading spaces",
                "four leading spaces"
            };

            var expected = new List<string>
            {
                "eading spaces",
                "ding spaces",
                "ading spaces"
            };

            Assert.Equal(expected, given.SubstringOnEach(7));
        }

        [Fact(DisplayName = "SubstringOnEach Should Throw Exception With Substring Index Greater Than Given")]
        public void SubstringOnEach_Should_Throw_Exception_With_Substring_Index_Greater_Than_Given()
        {
            var given = new List<string>
            {
                "three leading spaces",
                "two leading spaces",
                "four leading spaces"
            };

            Assert.Throws<ArgumentOutOfRangeException>(() => given.SubstringOnEach(999).ToList());
        }

        [Fact(DisplayName = "TrimStartSameAmountOnEach Should Succeed")]
        public void TrimStartSameAmountOnEach_Should_Succeed()
        {
            var given = new List<string>
            {
                "   three leading spaces",
                "  two leading spaces",
                "    four leading spaces"
            };

            var expected = new List<string>
            {
                " three leading spaces",
                "two leading spaces",
                "  four leading spaces"
            };

            Assert.Equal(expected, given.TrimStartSameAmountOnEach());
        }

        [Fact(DisplayName = "TrimStartSameAmountOnEach Should Succeed With No Leading Whitespace")]
        public void TrimStartSameAmountOnEach_Should_Succeed_With_No_Leading_Whitespace()
        {
            var given = new List<string>
            {
                "three leading spaces",
                "two leading spaces",
                "four leading spaces"
            };

            var expected = new List<string>
            {
                "three leading spaces",
                "two leading spaces",
                "four leading spaces"
            };

            Assert.Equal(expected, given.TrimStartSameAmountOnEach());
        }

        [Fact(DisplayName = "TrimStartSameAmountOnEach Should Succeed With Equal Leading Whitespace")]
        public void TrimStartSameAmountOnEach_Should_Succeed_With_Equal_Leading_Whitespace()
        {
            var given = new List<string>
            {
                "  three leading spaces",
                "  two leading spaces",
                "  four leading spaces"
            };

            var expected = new List<string>
            {
                "three leading spaces",
                "two leading spaces",
                "four leading spaces"
            };

            Assert.Equal(expected, given.TrimStartSameAmountOnEach());
        }
    }
}
