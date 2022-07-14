using System;
using System.Collections.Generic;

namespace LearnProject.FilterTask
{
    public static class ArrayExtension
    {
        public static int[] FilterByDigit(int[] source, int digit)
        {
            if (source is null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            if (source.Length == 0)
            {
                throw new ArgumentException("Array is empty!");
            }

            if (digit < 0 || digit > 9)
            {
                throw new ArgumentOutOfRangeException(nameof(digit));
            }

            List<int> listResult = new List<int>();

            foreach (int i in source)
            {
                if (IsСontainsNumber(Math.Abs(i), digit))
                {
                    listResult.Add(i);
                }
            }

            return listResult.ToArray();
        }

        public static bool IsСontainsNumber(int number, int digit)
        {
            List<int> list = new List<int>();

            if (number > 0)
            {
                while (number > 0)
                {
                    list.Add(number % 10);
                    number /= 10;
                }
            }
            else
            {
                list.Add(number);
            }

            if (list.Contains(digit))
            {
                return true;
            }

            return false;
        }
    }
}
