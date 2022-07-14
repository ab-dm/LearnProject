using System;

namespace LearnProject.JaggedArrays
{
    public static class ArrayExtension
    {
        public static void OrderByAscendingBySum(this int[][] source)
        {
            if (source is null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            int[] vs = new int[source.Length];

            for (int i = 0; i < source.Length; i++)
            {
                try
                {
                    for (int j = 0; j < source[i].Length; j++)
                    {
                        vs[i] += source[i][j];
                    }
                }
                catch
                {
                    vs[i] += int.MinValue;
                }
            }

            bool isSorted = false;
            while (!isSorted)
            {
                isSorted = true;
                for (int i = 1; i < vs.Length; i++)
                {
                    if (vs[i] < vs[i - 1])
                    {
                        int[] tmp = source[i];
                        source[i] = source[i - 1];
                        source[i - 1] = tmp;
                        int tmp2 = vs[i];
                        vs[i] = vs[i - 1];
                        vs[i - 1] = tmp2;
                        isSorted = false;
                    }
                }
            }
        }

        public static void OrderByDescendingBySum(this int[][] source)
        {
            if (source is null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            int[] vs = new int[source.Length];

            for (int i = 0; i < source.Length; i++)
            {
                try
                {
                    for (int j = 0; j < source[i].Length; j++)
                    {
                        vs[i] += source[i][j];
                    }
                }
                catch
                {
                    vs[i] += int.MinValue;
                }
            }

            bool isSorted = false;
            while (!isSorted)
            {
                isSorted = true;
                for (int i = 1; i < vs.Length; i++)
                {
                    if (vs[i] > vs[i - 1])
                    {
                        int[] tmp = source[i];
                        source[i] = source[i - 1];
                        source[i - 1] = tmp;
                        int tmp2 = vs[i];
                        vs[i] = vs[i - 1];
                        vs[i - 1] = tmp2;
                        isSorted = false;
                    }
                }
            }
        }

        public static void OrderByAscendingByMax(this int[][] source)
        {
            if (source is null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            int[] vs = new int[source.Length];
            int[][] tmpArr = new int[source.Length][];

            for (int i = 0; i < source.Length; i++)
            {
                try
                {
                    tmpArr[i] = (int[])source[i].Clone();
                    Array.Sort(tmpArr[i]);
                    vs[i] = tmpArr[i][^1];
                }
                catch
                {
                    tmpArr[i] = source[i];
                    vs[i] = int.MinValue;
                }
            }

            bool isSorted = false;
            while (!isSorted)
            {
                isSorted = true;
                for (int i = 1; i < vs.Length; i++)
                {
                    if (vs[i] < vs[i - 1])
                    {
                        int[] tmp = source[i];
                        source[i] = source[i - 1];
                        source[i - 1] = tmp;
                        int tmp2 = vs[i];
                        vs[i] = vs[i - 1];
                        vs[i - 1] = tmp2;
                        isSorted = false;
                    }
                }
            }
        }

        public static void OrderByDescendingByMax(this int[][] source)
        {
            if (source is null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            int[] vs = new int[source.Length];
            int[][] tmpArr = new int[source.Length][];

            for (int i = 0; i < source.Length; i++)
            {
                try
                {
                    tmpArr[i] = (int[])source[i].Clone();
                    Array.Sort(tmpArr[i]);
                    vs[i] = tmpArr[i][^1];
                }
                catch
                {
                    tmpArr[i] = source[i];
                    vs[i] = int.MinValue;
                }
            }

            bool isSorted = false;
            while (!isSorted)
            {
                isSorted = true;
                for (int i = 1; i < vs.Length; i++)
                {
                    if (vs[i] > vs[i - 1])
                    {
                        int[] tmp = source[i];
                        source[i] = source[i - 1];
                        source[i - 1] = tmp;
                        int tmp2 = vs[i];
                        vs[i] = vs[i - 1];
                        vs[i - 1] = tmp2;
                        isSorted = false;
                    }
                }
            }
        }
    }
}
