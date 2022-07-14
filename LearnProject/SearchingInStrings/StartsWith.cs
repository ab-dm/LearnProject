using System;

namespace LearnProject.SearchingInStrings
{
    public static class StartsWith
    {
        public static bool IsStartsWith(string str, char value)
        {
            if (str is null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            return str.StartsWith(value);
        }

        public static bool IsStartsWith(string str, string value)
        {
            if (str is null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            return str.StartsWith(value);
        }

        public static bool IsStartsWithStringComparison(string str, string value)
        {
            if (str is null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            return str.StartsWith(value, StringComparison.InvariantCulture);
        }
    }
}
