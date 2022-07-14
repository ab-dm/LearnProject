using System;
using System.Collections.Generic;

namespace LearnProject.WorkingWithStrings
{
    public static class JoiningStrings
    {
        public static string GetCommaSeparatedString(string[] values)
        {
            return string.Join(',', values);
        }

        public static string GetColonSeparatedString(string[] values)
        {
            return string.Join(':', values);
        }

        public static string GetCommaSeparatedStringWithoutFirstElement(string[] values)
        {
            return string.Join(',', values, 1, values.Length - 1);
        }

        public static string GetHyphenSeparatedStringWithoutFirstAndLastElements(string[] values)
        {
            return string.Join('-', values, 1, values.Length - 2);
        }

        public static string GetPlusSeparatedString(IEnumerable<string> values)
        {
            return string.Join('+', values);
        }

        public static string GetBackslashSeparatedString(IEnumerable<object> values)
        {
            return string.Join('\\', values);
        }

        public static string GetStringSeparatedString(object[] values)
        {
            return string.Join("], [", values);
        }

        public static string GetStringSeparatedStringForLastThreeElements(string separator, string[] values)
        {
            var searchString = values[^3];
            var index = Array.IndexOf(values, searchString);
            return string.Join(separator, values, index, 3);
        }
    }
}
