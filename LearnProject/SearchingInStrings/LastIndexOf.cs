using System;

namespace LearnProject.SearchingInStrings
{
    public static class LastIndexOf
    {
        public static int GetLastIndexOfChar(string str, char value)
        {
            return str.LastIndexOf(value);
        }

        public static int GetLastIndexOfChar(string str, char value, int startIndex)
        {
            return str.LastIndexOf(value, startIndex);
        }

        public static int GetLastIndexOfChar(string str, char value, int startIndex, int count)
        {
            return str.LastIndexOf(value, startIndex, count);
        }

        public static int GetLastIndexOfString(string str, string value)
        {
            return str.LastIndexOf(value);
        }

        public static int GetLastIndexOfStringOrdinal(string str, string value)
        {
            return str.LastIndexOf(value, StringComparison.Ordinal);
        }

        public static int GetLastIndexOfStringWithStringComparison(string str, string value)
        {
            return str.LastIndexOf(value, StringComparison.InvariantCulture);
        }

        public static int GetLastIndexOfString(string str, string value, int startIndex)
        {
            return str.LastIndexOf(value, startIndex);
        }

        public static int GetLastIndexOfStringCurrentCultureIgnoreCase(string str, string value, int startIndex)
        {
            return str.LastIndexOf(value, startIndex, StringComparison.CurrentCultureIgnoreCase);
        }

        public static int GetLastIndexOfStringWithStringComparison(string str, string value, int startIndex)
        {
            return str.LastIndexOf(value, startIndex, StringComparison.CurrentCulture);
        }

        public static int GetLastIndexOfString(string str, string value, int startIndex, int count)
        {
            return str.LastIndexOf(value, startIndex, count);
        }

        public static int GetLastIndexOfStringInvariantCulture(string str, string value, int startIndex, int count)
        {
            return str.LastIndexOf(value, startIndex, count, StringComparison.InvariantCulture);
        }

        public static int GetLastIndexOfStringWithStringComparison(string str, string value, int startIndex, int count)
        {
            return str.LastIndexOf(value, startIndex, count, StringComparison.CurrentCultureIgnoreCase);
        }
    }
}
