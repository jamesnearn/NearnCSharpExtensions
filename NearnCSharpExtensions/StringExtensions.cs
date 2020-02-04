namespace NearnCSharpExtensions
{
    public static class StringExtensions
    {
        public static int CountLeadingCharacters(this string source, char characterToMatch)
        {
            int matchCount = 0;
            for (int i = 0; i <= source.Length - 1; i++)
            {
                if (source[i] == characterToMatch)
                {
                    matchCount++;
                }
                else
                {
                    break;
                }
            }
            return matchCount;
        }

        public static string RemoveSpaces(this string source)
        {
            return source.Replace(" ", "");
        }
    }
}
