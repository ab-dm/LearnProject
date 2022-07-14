using System;

namespace LearnProject.SelectionSort
{
    public static class Sorter
    {
        public static void SelectionSort(this int[] array)
        {
            if (array is null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            for (int i = 0; i < array.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[min])
                    {
                        min = j;
                    }
                }

                int temp = array[min];
                array[min] = array[i];
                array[i] = temp;
            }
        }

        public static void RecursiveSelectionSort(this int[] array)
        {
            SelectionSortRec(array, 0);
        }

        public static void SelectionSortRec(int[] array, int index)
        {
            if (array is null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            if (index >= array.Length)
            {
                return;
            }

            int min = index;
            for (int j = index + 1; j < array.Length; j++)
            {
                if (array[j] < array[min])
                {
                    min = j;
                }
            }

            int temp = array[index];
            array[index] = array[min];
            array[min] = temp;

            SelectionSortRec(array, index + 1);
        }
    }
}
