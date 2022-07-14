using System;

namespace LearnProject.FindMaximumTask
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
                throw new ArgumentException("Array is empty");
            }

            int result = array[0];

            foreach (var item in array)
            {
                if (item > result)
                {
                    result = item;
                }
            }

            return result;
        }
    }
}
