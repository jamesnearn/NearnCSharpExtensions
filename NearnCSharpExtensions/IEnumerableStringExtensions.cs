using System.Collections.Generic;
using System.Linq;

namespace NearnCSharpExtensions
{
    public static class IEnumerableStringExtensions
    {
        public static int CountCommonLeadingCharactersOnEach(this IEnumerable<string> source, char leadingCharacter)
        {
            // todo - handle \n with IEnumerable<char>
            return source.Select(x => x.CountLeadingCharacters(leadingCharacter)).Min();
        }

        public static IEnumerable<string> SubstringOnEach(this IEnumerable<string> source, int startIndex)
        {
            foreach (string s in source)
            {
                yield return s.Substring(startIndex);
            }
        }
    }
}
