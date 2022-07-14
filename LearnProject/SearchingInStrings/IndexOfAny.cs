namespace LearnProject.SearchingInStrings
{
    public static class IndexOfAny
    {
        public static int GetIndexOfAnyChar(string str, char[] anyOf)
        {
            return str.IndexOfAny(anyOf);
        }

        public static int GetIndexOfAnyChar(string str, char[] anyOf, int startIndex)
        {
            return str.IndexOfAny(anyOf, startIndex);
        }

        public static int GetIndexOfAnyChar(string str, char[] anyOf, int startIndex, int count)
        {
            return str.IndexOfAny(anyOf, startIndex, count);
        }
    }
}
