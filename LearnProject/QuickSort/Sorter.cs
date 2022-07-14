using System;

namespace LearnProject.QuickSort
{
    public static class Sorter
    {
        public static void QuickSort(this int[] array)
        {
            if (array is null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            if (array.Length <= 1)
            {
                return;
            }

            int startIndex = 0;
            int endIndex = array.Length - 1;
            int top = -1;
            int[] stack = new int[array.Length];

            stack[++top] = startIndex;
            stack[++top] = endIndex;

            while (top >= 0)
            {
                endIndex = stack[top--];
                startIndex = stack[top--];

                int pivot = Partition(array, startIndex, endIndex);

                if (pivot - 1 > startIndex)
                {
                    stack[++top] = startIndex;
                    stack[++top] = pivot - 1;
                }

                if (pivot + 1 < endIndex)
                {
                    stack[++top] = pivot + 1;
                    stack[++top] = endIndex;
                }
            }
        }

        public static void RecursiveQuickSort(this int[] array)
        {
            if (array is null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            QuickSortRec(array, 0, array.Length - 1);
        }

        public static int[] QuickSortRec(int[] array, int startIndex, int endIndex)
        {
            if (startIndex >= endIndex)
            {
                return array;
            }

            var pivot = Partition(array, startIndex, endIndex);
            QuickSortRec(array, startIndex, pivot - 1);
            QuickSortRec(array, pivot + 1, endIndex);

            return array;
        }

        public static int Partition(int[] array, int left, int right)
        {
            if (array is null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            int x = array[right];
            int i = left - 1;

            for (int j = left; j <= right - 1; ++j)
            {
                if (array[j] <= x)
                {
                    ++i;
                    Swap(array, i, j);
                }
            }

            Swap(array, i + 1, right);

            return i + 1;
        }

        private static void Swap(int[] array, int i, int j)
        {
            if (array is null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}
