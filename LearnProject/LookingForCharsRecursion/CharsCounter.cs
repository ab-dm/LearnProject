using System;

namespace LearnProject.LookingForCharsRecursion
{
    public static class CharsCounter
    {
        public static int GetCharsCount(string str, char[] chars)
        {
            if (str is null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            if (chars is null)
            {
                throw new ArgumentNullException(nameof(chars));
            }

            return GetCharsCountRecurtion(str, chars, 0, 0);

            static int GetCharsCountRecurtion(string str, char[] chars, int indexStr, int indexChars)
            {
                if (indexChars >= chars.Length)
                {
                    indexChars = 0;
                    indexStr++;
                }

                if (indexStr >= str.Length)
                {
                    return 0;
                }

                return GetCharsCountRecurtion(str, chars, indexStr, indexChars + 1) + ((str[indexStr] == chars[indexChars]) ? 1 : 0);
            }
        }

        public static int GetCharsCount(string str, char[] chars, int startIndex, int endIndex)
        {
            if (str is null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            if (chars is null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            if (startIndex < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex), "startIndex is less than zero");
            }

            if (startIndex > endIndex)
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex), "startIndex is greater than str.Length");
            }

            if (str.Length == 0)
            {
                throw new ArgumentOutOfRangeException(nameof(endIndex), "endIndex is less than zero");
            }

            return GetCharsCountRecurtion(str, chars, startIndex, endIndex, 0);

            static int GetCharsCountRecurtion(string str, char[] chars, int startIndex, int endIndex, int indexChars)
            {
                if (indexChars >= chars.Length)
                {
                    indexChars = 0;
                    startIndex++;
                }

                if (startIndex > endIndex)
                {
                    return 0;
                }

                return GetCharsCountRecurtion(str, chars, startIndex, endIndex, indexChars + 1) + ((str[startIndex] == chars[indexChars]) ? 1 : 0);
            }
        }

        public static int GetCharsCount(string str, char[] chars, int startIndex, int endIndex, int limit)
        {
            if (str is null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            if (chars is null)
            {
                throw new ArgumentNullException(nameof(chars));
            }

            if (startIndex < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex), "startIndex is less than zero");
            }

            if (startIndex > endIndex)
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex), "startIndex is greater than str.Length");
            }

            if (str.Length == 0)
            {
                throw new ArgumentOutOfRangeException(nameof(str), "str is empty");
            }

            if (limit < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(limit), "limit is less than zero");
            }

            return GetCharsCountRecurtion(str, chars, startIndex, endIndex, limit, 0);

            static int GetCharsCountRecurtion(string str, char[] chars, int startIndex, int endIndex, int limit, int indexChars)
            {
                if (indexChars >= chars.Length)
                {
                    indexChars = 0;
                    startIndex++;
                }

                if (startIndex > endIndex)
                {
                    return 0;
                }

                if (str[startIndex] == chars[indexChars] && limit > 0)
                {
                    limit--;
                    return GetCharsCountRecurtion(str, chars, startIndex, endIndex, limit, indexChars + 1) + 1;
                }

                return GetCharsCountRecurtion(str, chars, startIndex, endIndex, limit, indexChars + 1);
            }
        }
    }
}
