using System;

namespace LearnProject.FindBalanceElementTask
{
    public static class ArrayExtension
    {
        public static int? FindBalanceElement(int[] array)
        {
            if (array is null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            if (array.Length == 0)
            {
                throw new ArgumentException("Array is empty!");
            }

            int indexBalanceElement;

            if (array.Length > 2)
            {
                long sumStart = 0;

                for (int i = 0; i < array.Length; i++)
                {
                    sumStart += array[i];
                    long sumEnd = 0;

                    for (int j = i + 2; j < array.Length; j++)
                    {
                        sumEnd += array[j];
                    }

                    if (sumStart == sumEnd)
                    {
                        indexBalanceElement = i + 1;
                        return indexBalanceElement;
                    }
                }
            }

            return null;
        }
    }
}
