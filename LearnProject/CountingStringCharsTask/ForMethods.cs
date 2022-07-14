using System;
using System.Collections.Generic;
using System.Text;

namespace LearnProject.CountingStringChars
{
    public class ForMethods
    {
        public static int GetCharCount(string str)
        {
            if (str is null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            int charCount = 0;
            for (int i = 0; i < str.Length; i++)
            {
                charCount++;
            }

            return charCount;
        }

        public static int GetUpperCharCount(string str)
        {
            if (str is null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            int upperCharCount = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsUpper(str[i]))
                {
                    upperCharCount++;
                }
            }

            return upperCharCount;
        }

        public static int GetCharCountRecursive(string str)
        {
            if (str is null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            return GetCharCountRecursive(str, 0);
        }

        public static int GetUpperCharCountRecursive(string str)
        {
            if (str is null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            return GetUpperCharCountRecursive(str, 0);
        }

        private static int GetCharCountRecursive(string str, int index)
        {
            if (index >= str.Length)
            {
                return 0;
            }

            return GetCharCountRecursive(str, index + 1) + 1;
        }

        private static int GetUpperCharCountRecursive(string str, int index)
        {
            if (index >= str.Length)
            {
                return 0;
            }

            bool isUpper = char.IsUpper(str[index]);
            int currentIncrement = isUpper ? 1 : 0;

            return GetUpperCharCountRecursive(str, index + 1) + currentIncrement;
        }
    }
}
