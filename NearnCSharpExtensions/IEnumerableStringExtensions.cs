using System.Collections.Generic;
using System.Linq;

namespace NearnCSharpExtensions
{
    public static class IEnumerableStringExtensions
    {
        public static IEnumerable<int> IndexOfAnyNotOnEach(this IEnumerable<string> source, char[] value)
        {
            foreach (string s in source)
            {
                yield return s.IndexOfAnyNot(value);
            }
        }

        public static IEnumerable<int> IndexOfNotOnEach(this IEnumerable<string> source, char value)
        {
            foreach (string s in source)
            {
                yield return s.IndexOfNot(value);
            }
        }

        public static IEnumerable<string> SubstringOnEach(this IEnumerable<string> source, int startIndex)
        {
            foreach (string s in source)
            {
                yield return s.Substring(startIndex);
            }
        }

        public static IEnumerable<string> TrimStartSameAmountOnEach(this IEnumerable<string> source)
        {
            var charsToTrim = new char[] { ' ', '\n' };
            var indexToTrimTo = source.IndexOfAnyNotOnEach(charsToTrim).Min();
            return source.SubstringOnEach(indexToTrimTo);
        }
    }
}
