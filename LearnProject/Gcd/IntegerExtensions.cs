using System;
using System.Diagnostics;

namespace LearnProject.Gcd
{
    public static class IntegerExtensions
    {
        public static int GetGcdByEuclidean(int a, int b)
        {
            if ((a == 0) && (b == 0))
            {
                throw new ArgumentException("all numbers are 0");
            }

            if ((a == int.MinValue) || (b == int.MinValue))
            {
                throw new ArgumentOutOfRangeException(nameof(a), nameof(b), "one or two numbers are int.MinValue");
            }

            while (b != 0)
            {
#pragma warning disable S1121 // Assignments should not be made from within sub-expressions
                b = a % (a = b);
#pragma warning restore S1121 // Assignments should not be made from within sub-expressions
            }

            return Math.Abs(a);
        }

        public static int GetGcdByEuclidean(int a, int b, int c)
        {
            if (a == 0 && b == 0 && c == 0)
            {
                throw new ArgumentException("Two numbers cannot be 0 at the same time.");
            }

            if (a == int.MinValue || b == int.MinValue || c == int.MinValue)
            {
                throw new ArgumentOutOfRangeException($"Number cannot be {int.MinValue}.");
            }

            while (b != 0)
            {
#pragma warning disable S1121 // Assignments should not be made from within sub-expressions
                b = a % (a = b);
#pragma warning restore S1121 // Assignments should not be made from within sub-expressions
            }

            while (c != 0)
            {
#pragma warning disable S1121 // Assignments should not be made from within sub-expressions
                c = a % (a = c);
#pragma warning restore S1121 // Assignments should not be made from within sub-expressions
            }

            return Math.Abs(a);
        }

        public static int GetGcdByEuclidean(int a, int b, params int[] other)
        {
            if ((a == 0) && (b == 0) && (other is null))
            {
                throw new ArgumentException("all numbers are 0");
            }

            int result = 0;

            if (a != 0 || b != 0)
            {
                result = GetGcdByEuclidean(a, b);
            }

            foreach (int c in other)
            {
                if (c != 0)
                {
                    result = GetGcdByEuclidean(result, c);
                }
            }

            if (result == 0)
            {
                throw new ArgumentException("all numbers are 0");
            }

            return result;
        }

#pragma warning disable S4136 // Method overloads should be grouped together
        public static int GetGcdByStein(int a, int b)
#pragma warning restore S4136 // Method overloads should be grouped together
        {
            if ((a == int.MinValue) || (b == int.MinValue))
            {
                throw new ArgumentOutOfRangeException(nameof(a), nameof(b), "one or two numbers are int.MinValue");
            }

            a = Math.Abs(a);
            b = Math.Abs(b);

            if (a == 0 && b != 0)
            {
                return b;
            }

            if (b == 0 && a != 0)
            {
                return a;
            }

            if (a == 0 && b == 0)
            {
                throw new ArgumentException("all numbers are 0");
            }

            if (a == b)
            {
                return a;
            }

            bool aIsEven = (a & 1u) == 0;
            bool bIsEven = (b & 1u) == 0;
            int result;
            if (aIsEven && bIsEven)
            {
                result = GetGcdByStein(a >> 1, b >> 1) << 1;
            }
            else if (aIsEven && !bIsEven)
            {
                result = GetGcdByStein(a >> 1, b);
            }
            else if (bIsEven)
            {
                result = GetGcdByStein(a, b >> 1);
            }
            else if (a > b)
            {
                result = GetGcdByStein((a - b) >> 1, b);
            }
            else
            {
                result = GetGcdByStein(a, (b - a) >> 1);
            }

            if (result == 0)
            {
                throw new ArgumentException("all numbers are 0");
            }

            return result;
        }

        public static int GetGcdByStein(int a, int b, int c)
        {
            if ((a == int.MinValue) || (b == int.MinValue) || (c == int.MinValue))
            {
                throw new ArgumentOutOfRangeException(nameof(a), nameof(b), "one or two or more numbers are int.MinValue");
            }

            if ((a == 0) && (b == 0) && (c == 0))
            {
                throw new ArgumentException("all numbers are 0");
            }

            a = Math.Abs(a);
            b = Math.Abs(b);
            c = Math.Abs(c);

            int result = GetGcdByStein(b, GetGcdByStein(a, c));

            return result;
        }

        public static int GetGcdByStein(int a, int b, params int[] other)
        {
            int sum = a + b;
            foreach (var item in other)
            {
                sum += item;
            }

            if ((a == 0) && (b == 0) && (other.Length == 0))
            {
                throw new ArgumentException("All numbers cannot be 0 at the same time.");
            }

            if (other.Length == 0)
            {
                return GetGcdByStein(a, b);
            }

            int result = 0;

            if (a != 0 || b != 0)
            {
                result = GetGcdByStein(a, b);
            }

            foreach (int item in other)
            {
                if (item != 0)
                {
                    result = GetGcdByStein(result, item);
                }
            }

            if (result == 0)
            {
                throw new ArgumentException("all numbers are 0");
            }

            return result;
        }

        public static int GetGcdByEuclidean(out long elapsedTicks, int a, int b)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            if ((a == 0) && (b == 0))
            {
                throw new ArgumentException("all numbers are 0");
            }

            if ((a == int.MinValue) || (b == int.MinValue))
            {
                throw new ArgumentOutOfRangeException(nameof(a), nameof(b), "one or two numbers are int.MinValue");
            }

            a = Math.Abs(a);
            b = Math.Abs(b);

            while (b != 0)
            {
#pragma warning disable S1121 // Assignments should not be made from within sub-expressions
                b = a % (a = b);
#pragma warning restore S1121 // Assignments should not be made from within sub-expressions
            }

            stopwatch.Stop();
            elapsedTicks = stopwatch.ElapsedMilliseconds;

            return a;
        }

        public static int GetGcdByEuclidean(out long elapsedTicks, int a, int b, int c)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            if (a == 0 && b == 0 && c == 0)
            {
                throw new ArgumentException("Two numbers cannot be 0 at the same time.");
            }

            if (a == int.MinValue || b == int.MinValue || c == int.MinValue)
            {
                throw new ArgumentOutOfRangeException($"Number cannot be {int.MinValue}.");
            }

            a = Math.Abs(a);
            b = Math.Abs(b);
            c = Math.Abs(c);

            while (b != 0)
            {
#pragma warning disable S1121 // Assignments should not be made from within sub-expressions
                b = a % (a = b);
#pragma warning restore S1121 // Assignments should not be made from within sub-expressions
            }

            while (c != 0)
            {
#pragma warning disable S1121 // Assignments should not be made from within sub-expressions
                c = a % (a = c);
#pragma warning restore S1121 // Assignments should not be made from within sub-expressions
            }

            stopwatch.Stop();
            elapsedTicks = stopwatch.ElapsedMilliseconds;

            return a;
        }

        public static int GetGcdByEuclidean(out long elapsedTicks, int a, int b, params int[] other)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            if ((a == 0) && (b == 0) && (other is null))
            {
                throw new ArgumentException("all numbers are 0");
            }

            int result = 0;

            if (a != 0 || b != 0)
            {
                result = GetGcdByEuclidean(a, b);
            }

            foreach (int item in other)
            {
                if (item != 0)
                {
                    result = GetGcdByEuclidean(result, item);
                }
            }

            if (result == 0)
            {
                throw new ArgumentException("all numbers are 0");
            }

            stopwatch.Stop();
            elapsedTicks = stopwatch.ElapsedMilliseconds;

            return result;
        }

        public static int GetGcdByStein(out long elapsedTicks, int a, int b)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            elapsedTicks = 0;

            if ((a == int.MinValue) || (b == int.MinValue))
            {
                throw new ArgumentOutOfRangeException(nameof(a), nameof(b), "one or two numbers are int.MinValue");
            }

            a = Math.Abs(a);
            b = Math.Abs(b);

            if (a == 0 && b != 0)
            {
                return b;
            }

            if (b == 0 && a != 0)
            {
                return a;
            }

            if (a == 0 && b == 0)
            {
                throw new ArgumentException("all numbers are 0");
            }

            if (a == b)
            {
                return a;
            }

            bool aIsEven = (a & 1u) == 0;
            bool bIsEven = (b & 1u) == 0;
            int result;
            if (aIsEven && bIsEven)
            {
                result = GetGcdByStein(a >> 1, b >> 1) << 1;
            }
            else if (aIsEven && !bIsEven)
            {
                result = GetGcdByStein(a >> 1, b);
            }
            else if (bIsEven)
            {
                result = GetGcdByStein(a, b >> 1);
            }
            else if (a > b)
            {
                result = GetGcdByStein((a - b) >> 1, b);
            }
            else
            {
                result = GetGcdByStein(a, (b - a) >> 1);
            }

            if (result == 0)
            {
                throw new ArgumentException("all numbers are 0");
            }

            stopwatch.Stop();
            elapsedTicks = stopwatch.ElapsedMilliseconds;

            return result;
        }

        public static int GetGcdByStein(out long elapsedTicks, int a, int b, int c)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            if ((a == int.MinValue) || (b == int.MinValue) || (c == int.MinValue))
            {
                throw new ArgumentOutOfRangeException(nameof(a), nameof(b), "one or two or more numbers are int.MinValue");
            }

            if ((a == 0) && (b == 0) && (c == 0))
            {
                throw new ArgumentException("all numbers are 0");
            }

            a = Math.Abs(a);
            b = Math.Abs(b);
            c = Math.Abs(c);

            int result = GetGcdByStein(b, GetGcdByStein(a, c));

            stopwatch.Stop();
            elapsedTicks = stopwatch.ElapsedMilliseconds;

            return result;
        }

        public static int GetGcdByStein(out long elapsedTicks, int a, int b, params int[] other)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            elapsedTicks = 0;

            int sum = a + b;
            foreach (var item in other)
            {
                sum += item;
            }

            if ((a == 0) && (b == 0) && (other.Length == 0))
            {
                throw new ArgumentException("All numbers cannot be 0 at the same time.");
            }

            if (other.Length == 0)
            {
                return GetGcdByStein(a, b);
            }

            int result = 0;

            if (a != 0 || b != 0)
            {
                result = GetGcdByStein(a, b);
            }

            foreach (int item in other)
            {
                if (item != 0)
                {
                    result = GetGcdByStein(result, item);
                }
            }

            if (result == 0)
            {
                throw new ArgumentException("all numbers are 0");
            }

            stopwatch.Stop();
            elapsedTicks = stopwatch.ElapsedMilliseconds;

            return result;
        }
    }
}
