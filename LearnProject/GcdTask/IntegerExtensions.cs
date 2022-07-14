using System;

namespace LearnProject.GcdTask
{
    public static class IntegerExtensions
    {
        public static int FindGcd(int a, int b)
        {
            if (a == 0 && b == 0)
            {
                throw new ArgumentException("Two numbers cannot be 0 at the same time.");
            }

            if (a == int.MinValue || b == int.MinValue)
            {
                throw new ArgumentOutOfRangeException($"Number cannot be {int.MinValue}.");
            }

            while (b != 0)
            {
                int t = b;
                b = a % b;
                a = t;
            }

            return Math.Abs(a);
        }
    }
}
