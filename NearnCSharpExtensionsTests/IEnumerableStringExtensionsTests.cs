using System;
using System.Collections.Generic;
using System.Linq;
using NearnCSharpExtensions;
using Xunit;

namespace NearnCSharpExtensionsTests
{
    public class IEnumerableStringExtensionsTests
    {
        [Fact(DisplayName = "CountCommonLeadingCharactersOnEach Should Succeed")]
        public void CountCommonLeadingCharactersOnEach_Should_Succeed()
        {
            var given = new List<string>
            {
                "   three leading spaces",
                "  two leading spaces",
                "    four leading spaces"
            };

            Assert.Equal(2, given.CountCommonLeadingCharactersOnEach(' '));
        }

        [Fact(DisplayName = "CountCommonLeadingCharactersOnEach Should Succeed With No Leading Whitespace")]
        public void CountCommonLeadingCharactersOnEach_Should_Succeed_With_No_Leading_Whitespace()
        {
            var given = new List<string>
            {
                "three leading spaces",
                "two leading spaces",
                "four leading spaces"
            };

            Assert.Equal(0, given.CountCommonLeadingCharactersOnEach(' '));
        }

        [Fact(DisplayName = "CountCommonLeadingCharactersOnEach Should Succeed With Equal Leading Whitespace")]
        public void CountCommonLeadingCharactersOnEach_Should_Succeed_With_Equal_Leading_Whitespace()
        {
            var given = new List<string>
            {
                "three leading spaces",
                "two leading spaces",
                "four leading spaces"
            };

            Assert.Equal(0, given.CountCommonLeadingCharactersOnEach(' '));
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
    }
}
