using System;

namespace LearnProject.FindMaximumRecursion
{
    public static class ArrayExtension
    {
        public static int FindMaximum(int[] array)
        {
            if (array is null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            if (array.Length == 0)
            {
                throw new ArgumentException($"source cannot be empty.");
            }

            return FindMaximumRecursive(array, 0, array.Length);

            static int FindMaximumRecursive(int[] array, int start, int length)
            {
                if (start == length - 1)
                {
                    return array[start];
                }

                int mid = (start + length) / 2;
                int left = FindMaximumRecursive(array, start, mid);
                int right = FindMaximumRecursive(array, mid, length);

                return (left > right) ? left : right;
            }
        }
    }
}
