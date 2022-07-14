using System.Collections.Generic;

namespace LearnProject.WorkingWithStrings
{
    public static class ConcatenatingStrings
    {
        public static string ConcatenateStrings(string str1, string str2)
        {
            return string.Concat(str1, str2);
        }

        public static string ConcatenateStrings(string st1, string st2, string st3)
        {
            return string.Concat(st1, st2, st3);
        }

        public static string ConcatenateStrings(string st1, string st2, string st3, string st4)
        {
            return string.Concat(st1, st2, st3, st4);
        }

        public static string ConcatenateStrings(IEnumerable<string> strings)
        {
            return string.Concat(strings);
        }

        public static string ConcatenateValues(string str, int intValue, long longValue)
        {
            return string.Concat(str, intValue, longValue);
        }

        public static string ConcatenateValues(short shortValue, float floatValue, bool boolValue, double doubleValue)
        {
            return string.Concat(shortValue, floatValue, boolValue, doubleValue);
        }

        public static string ConcatenateValues(IEnumerable<object> values)
        {
            return string.Concat(values);
        }
    }
}
