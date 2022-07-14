using System;

namespace LearnProject.PalindromicNumberTask
{
    public static class NumbersExtension
    {
        public static bool IsPalindromicNumber(int number)
        {
            if (number < 0)
            {
                throw new ArgumentException("number cannot be less than zero");
            }

            static bool IsPalindromicNumber(int number, int numberReversed, int numberOriginal)
            {
                if (number == 0)
                {
                    return numberReversed == numberOriginal;
                }
                else
                {
                    var currentDigit = number % 10;
                    numberReversed = (numberReversed * 10) + currentDigit;
                    number /= 10;
                    return IsPalindromicNumber(number, numberReversed, numberOriginal);
                }
            }

            return IsPalindromicNumber(number, 0, number);
        }
    }
}
