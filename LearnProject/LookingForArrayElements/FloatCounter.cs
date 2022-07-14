using System;

namespace LearnProject.LookingForArrayElements
{
    public static class FloatCounter
    {
        public static int GetFloatsCount(float[] arrayToSearch, float[] rangeStart, float[] rangeEnd)
        {
            if (arrayToSearch is null || rangeStart is null || rangeEnd is null)
            {
                throw new ArgumentNullException(nameof(arrayToSearch));
            }

            if (rangeStart.Length == 0)
            {
                return 0;
            }

            if (rangeStart.Length != rangeEnd.Length)
            {
                throw new ArgumentException("Method throws ArgumentException in case an arrays of range starts and range ends contain different number of elements.");
            }

            if (rangeStart[0] > rangeEnd[0] || rangeStart[rangeStart.Length - 1] > rangeEnd[rangeStart.Length - 1])
            {
                throw new ArgumentException("Method throws ArgumentException in case the range start value is greater than the range end value.");
            }

            int result = 0;
            for (int i = 0; i < arrayToSearch.Length; i++)
            {
                for (int j = 0; j < rangeStart.Length; j++)
                {
                    if (rangeStart[j] <= arrayToSearch[i] && rangeEnd[j] >= arrayToSearch[i])
                    {
                        result++;
                    }
                }
            }

            return result;
        }

        public static int GetFloatsCount(float[] arrayToSearch, float[] rangeStart, float[] rangeEnd, int startIndex, int count)
        {
            if (startIndex < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex));
            }

            if (arrayToSearch is null || rangeStart is null || rangeEnd is null)
            {
                throw new ArgumentNullException(nameof(arrayToSearch));
            }

            if (rangeStart.Length == 0)
            {
                return 0;
            }

            if (rangeStart.Length != rangeEnd.Length)
            {
                throw new ArgumentException("Method throws ArgumentException in case an arrays of range starts and range ends contain different number of elements.");
            }

            if (rangeStart[0] > rangeEnd[0] || rangeStart[rangeStart.Length - 1] > rangeEnd[rangeStart.Length - 1])
            {
                throw new ArgumentException("in case the range start value is greater than the range end value.");
            }

            if (startIndex > arrayToSearch.Length || count < 0 || (startIndex + count) > arrayToSearch.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex));
            }

            int result = 0;
            for (int i = startIndex; i < startIndex + count; i++)
            {
                for (int j = 0; j < rangeStart.Length; j++)
                {
                    if (rangeStart[j] <= arrayToSearch[i] && rangeEnd[j] >= arrayToSearch[i])
                    {
                        result++;
                    }
                }
            }

            return result;
        }
    }
}
