using System;

namespace LearnProject.CountingStringChars
{
    public class WhileMethods
    {
        public static int GetSpaceCount(string str)
        {
            if (str is null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            if (string.IsNullOrEmpty(str))
            {
                return 0;
            }

            int spaceCount = 0;
            int count = 0;
            while (count < str.Length)
            {
                if (str[count] == ' ')
                {
                    spaceCount++;
                }

                count++;
            }

            return spaceCount;
        }

        public static int GetPunctuationCount(string str)
        {
            if (str is null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            if (string.IsNullOrEmpty(str))
            {
                return 0;
            }

            int spaceCount = 0;
            int count = 0;
            while (count < str.Length)
            {
                if (char.IsPunctuation(str[count]))
                {
                    spaceCount++;
                }

                count++;
            }

            return spaceCount;
        }

        public static int GetSpaceCountRecursive(string str)
        {
            if (str is null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            if (string.IsNullOrEmpty(str))
            {
                return 0;
            }

            int result = GetSpaceCountRecursive(str[1..]) + (char.IsWhiteSpace(str[0]) ? 1 : 0);

            return result;
        }

        public static int GetPunctuationCountRecursive(string str)
        {
            if (str is null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            if (string.IsNullOrEmpty(str))
            {
                return 0;
            }

            bool isPunctuation = char.IsPunctuation(str[0]);
            int currentIncrement = isPunctuation ? 1 : 0;
            int result = GetPunctuationCountRecursive(str[1..]) + currentIncrement;

            return result;
        }
    }
}
