using System.Linq;

namespace NearnCSharpExtensions
{
    public static class StringExtensions
    {
        /// <summary>
        /// Returns the index of the first character not matching any value
        /// </summary>
        /// <param name="source"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static int IndexOfAnyNot(this string source, char[] value)
        {
            var match = source.Where(x => !value.Contains(x)).FirstOrDefault();
            return source.IndexOf(match);
        }

        /// <summary>
        /// Returns the index of the first character not matching value
        /// </summary>
        /// <param name="source"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static int IndexOfNot(this string source, char value)
        {
            var match = source.Where(x => x != value).FirstOrDefault();
            return source.IndexOf(match);
        }

        /// <summary>
        /// uses .Replace() to remove spaces
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static string RemoveSpaces(this string source)
        {
            return source.Replace(" ", "");
        }
    }
}
