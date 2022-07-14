using System;
using System.Collections;

namespace LearnProject.PrimeFactorsTask
{
    public static class PrimeFactors
    {
        public static int[] GetFactors(int number)
        {
            if (number <= 0)
            {
                throw new ArgumentException($"{number} cannot be less or equals zero.");
            }

            var list = new ArrayList() { };

            for (int n = 2; n <= number; n++)
            {
                while (number % n == 0)
                {
                    list.Add(n);
                    number /= n;
                }
            }

            var resArray = new int[list.Count];
            list.CopyTo(resArray);
            return resArray;
        }
    }
}
