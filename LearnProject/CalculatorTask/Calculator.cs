using System;

namespace LearnProject.Calculator
{
    public class Calculator
    {
        public static double GetSumOne(int n)
        {
            double sum = 0.0;

            for (double i = 1.0; i <= n; i++)
            {
                sum += 1 / i;
            }

            return sum;
        }

        public static double GetSumTwo(int n)
        {
            double sum = 0.0;
            double num = -1.0;

            for (int j = 0; j < n + 1; j++)
            {
                num *= num;
            }

            for (int i = 1, j = 2; i <= n && j <= n; i += 2, j += 2)
            {
                sum += num / (i * (i + 1.0));
                sum -= num / (j * (j + 1.0));
            }

            return sum;
        }

        public static double GetSumThree(int n)
        {
            double sum = 0.0;

            for (double i = 1.0; i <= n; i++)
            {
                double exp = i * i * i * i * i;

                sum += 1.0 / exp;
            }

            return sum;
        }

        public static double GetSumFour(int n)
        {
            double sum = 0.0;

            for (double i = 1.0; i <= n; i++)
            {
                sum += 1.0 / ((2.0 * i + 1.0) * (2.0 * i + 1.0));
            }

            return sum;
        }

        public static double GetProductOne(int n)
        {
            double sum = 1;

            for (double i = 1; i <= n; i++)
            {
                double denominator = i * i;
                sum *= 1 + 1 / denominator;
            }

            return sum;
        }

        public static double GetSumFive(int n)
        {
            double sum = 0.0;
            double numerator = -1.0;
            int count = 0;

            while (count <= n - 1)
            {
                numerator *= numerator;
                count++;
            }

            for (int i = 1, j = 2; i <= n && j <= n; i += 2, j += 2)
            {
                double denominator = 2 * i + 1;
                sum -= numerator / denominator;
                double denominator2 = 2 * j + 1;
                sum += numerator / denominator2;
            }

            return sum;
        }

        public static double GetSumSix(int n)
        {
            double numerator = 1;
            double denominator = 1;
            double sum = 1;

            for (int i = 2; i <= n; i++)
            {
                numerator *= i;
                denominator += 1.0 / i;
                sum += numerator / denominator;
            }

            return sum;
        }

        public static double GetSumSeven(int n)
        {
            double sum = 0;

            for (int i = 1; i <= n; i++)
            {
                sum = Math.Sqrt(2 + sum);
            }

            return sum;
        }

        public static double GetSumEight(int n)
        {
            double sum = 0;
            double denominator = 0;
            for (double i = 1; i <= n; i++)
            {
                denominator += Math.Sin(i * (Math.PI / 180));
                sum += 1 / denominator;
            }

            return sum;
        }
    }
}
