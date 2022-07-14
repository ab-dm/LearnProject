using System;

namespace LearnProject.SearchingInStrings
{
    public static class EndsWith
    {
        public static bool IsEndsWith(string str, char value)
        {
            if (str is null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            return str.EndsWith(value);
        }

        public static bool IsEndsWith(string str, string value)
        {
            if (str is null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            return str.EndsWith(value);
        }

        public static bool IsEndsWithStringComparison(string str, string value)
        {
            if (str is null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            return str.EndsWith(value, StringComparison.InvariantCulture);
        }
    }
}
