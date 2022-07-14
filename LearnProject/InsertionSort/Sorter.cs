using System;

namespace LearnProject.InsertionSort
{
    public static class Sorter
    {
        public static void InsertionSort(this int[] array)
        {
            if (array is null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            for (int i = 1; i < array.Length; i++)
            {
                int current = array[i];
                int j = i;
                while (j > 0 && array[j - 1] > current)
                {
                    array[j] = array[j - 1];
                    j--;
                }

                array[j] = current;
            }
        }

        public static void RecursiveInsertionSort(this int[] array)
        {
            if (array is null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            InsertionSortRec(array, 1, array.Length - 1);
        }

        public static int[] InsertionSortRec(int[] array, int i, int n)
        {
            if (array is null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            if (array.Length <= 1)
            {
                return array;
            }

            int value = array[i];
            int j = i;

            while (j > 0 && array[j - 1] > value)
            {
                array[j] = array[j - 1];
                j--;
            }

            array[j] = value;

            if (i + 1 <= n)
            {
                InsertionSortRec(array, i + 1, n);
            }

            return array;
        }
    }
}
