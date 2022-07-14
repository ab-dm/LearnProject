using System;

namespace LearnProject.LookingForArrayElementsRecursion
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

            return GetFloatsCountRecurtion(arrayToSearch, rangeStart, rangeEnd, 0, 0);

            static int GetFloatsCountRecurtion(float[] arrayToSearch, float[] rangeStart, float[] rangeEnd, int indexArrayToSearch, int indexElementsRange)
            {
                if (indexElementsRange >= rangeStart.Length)
                {
                    indexElementsRange = 0;
                    indexArrayToSearch++;
                }

                if (indexArrayToSearch >= arrayToSearch.Length)
                {
                    return 0;
                }

                if (rangeStart[indexElementsRange] <= arrayToSearch[indexArrayToSearch] && rangeEnd[indexElementsRange] >= arrayToSearch[indexArrayToSearch])
                {
                    return GetFloatsCountRecurtion(arrayToSearch, rangeStart, rangeEnd, indexArrayToSearch, indexElementsRange + 1) + 1;
                }

                return GetFloatsCountRecurtion(arrayToSearch, rangeStart, rangeEnd, indexArrayToSearch, indexElementsRange + 1);
            }
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

            return GetFloatsCountRecurtion(arrayToSearch, rangeStart, rangeEnd, startIndex, count, 0);

            static int GetFloatsCountRecurtion(float[] arrayToSearch, float[] rangeStart, float[] rangeEnd, int startIndex, int count, int indexElementsRange)
            {
                if (indexElementsRange >= rangeStart.Length)
                {
                    indexElementsRange = 0;
                    startIndex++;
                    count--;
                }

                if (startIndex >= arrayToSearch.Length || count == 0)
                {
                    return 0;
                }

                if ((rangeStart[indexElementsRange] <= arrayToSearch[startIndex] && rangeEnd[indexElementsRange] >= arrayToSearch[startIndex]) && count > 0)
                {
                    return GetFloatsCountRecurtion(arrayToSearch, rangeStart, rangeEnd, startIndex, count, indexElementsRange + 1) + 1;
                }

                return GetFloatsCountRecurtion(arrayToSearch, rangeStart, rangeEnd, startIndex, count, indexElementsRange + 1);
            }
        }
    }
}
