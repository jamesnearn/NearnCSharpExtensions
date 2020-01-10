namespace NearnCSharpExtensions
{
    public static class StringExtensions
    {
        public static string RemoveSpaces(this string source)
        {
            return source.Replace(" ", "");
        }
    }
}
