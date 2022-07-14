using System;

namespace LearnProject.BubbleSort
{
    public static class Sorter
    {
        public static void BubbleSort(this int[] array)
        {
            if (array is null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            bool isSorted = false;
            while (!isSorted)
            {
                isSorted = true;
                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i] < array[i - 1])
                    {
                        int tmp = array[i];
                        array[i] = array[i - 1];
                        array[i - 1] = tmp;
                        isSorted = false;
                    }
                }
            }
        }

        public static void RecursiveBubbleSort(this int[] array)
        {
            if (array is null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            BubbleSortRec(array, array.Length);
        }

        public static void BubbleSortRec(int[] array, int index)
        {
            if (array is null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            if (index < 0)
            {
                return;
            }

            for (int i = 0; i < index - 1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    int tmp = array[i];
                    array[i] = array[i + 1];
                    array[i + 1] = tmp;
                }
            }

            BubbleSortRec(array, index - 1);
        }
    }
}
