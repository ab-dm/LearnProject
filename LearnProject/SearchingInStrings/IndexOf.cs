using System;

namespace LearnProject.SearchingInStrings
{
    public static class IndexOf
    {
        public static int GetIndexOfChar(string str, char value)
        {
            return str.IndexOf(value);
        }

        public static int GetIndexOfCharInvariantCultureIgnoreCase(string str, char value)
        {
            return str.IndexOf(value, StringComparison.InvariantCultureIgnoreCase);
        }

        public static int GetIndexOfCharWithStringComparison(string str, char value)
        {
            return str.IndexOf(value, StringComparison.OrdinalIgnoreCase);
        }

        public static int GetIndexOfChar(string str, char value, int startIndex)
        {
            return str.IndexOf(value, startIndex);
        }

        public static int GetIndexOfChar(string str, char value, int startIndex, int count)
        {
            return str.IndexOf(value, startIndex, count);
        }

        public static int GetIndexOfString(string str, string value)
        {
            return str.IndexOf(value);
        }

        public static int GetIndexOfStringOrdinal(string str, string value)
        {
            return str.IndexOf(value, StringComparison.Ordinal);
        }

        public static int GetIndexOfStringWithStringComparison(string str, string value)
        {
            return str.IndexOf(value, StringComparison.InvariantCulture);
        }

        public static int GetIndexOfString(string str, string value, int startIndex)
        {
            return str.IndexOf(value, startIndex);
        }

        public static int GetIndexOfStringCurrentCultureIgnoreCase(string str, string value, int startIndex)
        {
            return str.IndexOf(value, StringComparison.CurrentCultureIgnoreCase);
        }

        public static int GetIndexOfStringWithStringComparison(string str, string value, int startIndex)
        {
            return str.IndexOf(value, startIndex, StringComparison.CurrentCulture);
        }

        public static int GetIndexOfString(string str, string value, int startIndex, int count)
        {
            return str.IndexOf(value, startIndex, count);
        }

        public static int GetIndexOfStringInvariantCulture(string str, string value, int startIndex, int count)
        {
            return str.IndexOf(value, startIndex, count, StringComparison.InvariantCulture);
        }

        public static int GetIndexOfStringWithStringComparison(string str, string value, int startIndex, int count)
        {
            return str.IndexOf(value, startIndex, count, StringComparison.CurrentCultureIgnoreCase);
        }
    }
}
