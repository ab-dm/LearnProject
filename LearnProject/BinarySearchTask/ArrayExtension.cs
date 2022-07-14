using System;

namespace LearnProject.BinarySearchTask
{
    public static class ArrayExtension
    {
        public static int? BinarySearch(int[] source, int value)
        {
            if (source is null)
            {
                throw new ArgumentNullException(nameof(source), "Source array cannot be null.");
            }

            int left = 0;
            int right = source.Length - 1;
            int searchElement;

            while (left <= right)
            {
                searchElement = (left + right) / 2;

                if (source[searchElement] > value)
                {
                    right = searchElement - 1;
                }
                else if (source[searchElement] < value)
                {
                    left = searchElement + 1;
                }
                else
                {
                    return searchElement;
                }
            }

            return null;
        }
    }
}
