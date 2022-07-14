using System;
using System.Collections.Generic;
using System.Text;

namespace LearnProject.LookingForChars
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

            int countOfVowel = 0;
            for (int itemChars = 0; itemChars < chars.Length; itemChars++)
            {
                for (int itemStr = 0; itemStr < str.Length; itemStr++)
                {
                    if (chars[itemChars] == str[itemStr])
                    {
                        countOfVowel++;
                    }
                }
            }

            return countOfVowel;
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

            int charsCount = 0;
            while (startIndex <= endIndex)
            {
                int charIndex = 0;
                while (charIndex < chars.Length)
                {
                    if (chars[charIndex] == str[startIndex])
                    {
                        charsCount++;
                    }

                    charIndex++;
                }

                startIndex++;
            }

            return charsCount;
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

            int charsCount = 0;
            int charIndex = 0;

            do
            {
                int strIndex = startIndex;
                do
                {
                    if (chars[charIndex] == str[strIndex] && limit > 0)
                    {
                        charsCount++;
                        limit--;
                    }

                    strIndex++;
                }
                while (strIndex <= endIndex);

                charIndex++;
            }
            while (charIndex < chars.Length);

            return charsCount;
        }
    }
}
