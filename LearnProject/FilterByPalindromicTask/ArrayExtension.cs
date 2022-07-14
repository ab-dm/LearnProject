using System;
using System.Collections.Generic;

namespace LearnProject.FilterByPalindromicTask
{
    public static class ArrayExtension
    {
        public static int[] FilterByPalindromic(int[] source)
        {
            if (source is null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            if (source.Length == 0)
            {
                throw new ArgumentException("Array is empty.");
            }

            List<int> result = new List<int>();

            for (int i = 0; i < source.Length; i++)
            {
                if (IsPalindrom(source[i]))
                {
                    result.Add(source[i]);
                }
            }

            return result.ToArray();
        }

        public static bool IsPalindrom(int number)
        {
            int numberReversed = 0;
            int numberOriginal = number;

            while (number > 0)
            {
                var currentDigit = number % 10;
                numberReversed = (numberReversed * 10) + currentDigit;
                number /= 10;
            }

            return numberReversed == numberOriginal;
        }
    }
}
