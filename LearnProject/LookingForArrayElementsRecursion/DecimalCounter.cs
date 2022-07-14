using System;
using System.Linq;

namespace LearnProject.LookingForArrayElementsRecursion
{
    public static class DecimalCounter
    {
        public static int GetDecimalsCount(decimal[] arrayToSearch, decimal[][] ranges)
        {
            if (arrayToSearch is null)
            {
                throw new ArgumentNullException(nameof(arrayToSearch));
            }

            if (ranges is null)
            {
                throw new ArgumentNullException(nameof(ranges));
            }

            if (ranges.Any(x => x?.Length > 2))
            {
                throw new ArgumentException("Invalid ranges", nameof(ranges));
            }

            for (int i = 0; i < ranges.Length; i++)
            {
                if (ranges[i] is null)
                {
                    throw new ArgumentNullException(nameof(ranges));
                }
            }

            return GetFloatsCountRecurtion(arrayToSearch, ranges, 0, 0);

            static int GetFloatsCountRecurtion(decimal[] arrayToSearch, decimal[][] ranges, int indexArrayToSearch, int indexElementsRange)
            {
                if (indexElementsRange >= ranges.Length)
                {
                    indexElementsRange = 0;
                    indexArrayToSearch++;
                }

                if (indexArrayToSearch >= arrayToSearch.Length || ranges.Length == 0 || ranges[indexElementsRange].Length == 0 || arrayToSearch.Length == 0)
                {
                    return 0;
                }

                if (arrayToSearch[indexArrayToSearch] >= ranges[indexElementsRange][0] && arrayToSearch[indexArrayToSearch] <= ranges[indexElementsRange][1])
                {
                    return GetFloatsCountRecurtion(arrayToSearch, ranges, indexArrayToSearch + 1, indexElementsRange) + 1;
                }

                return GetFloatsCountRecurtion(arrayToSearch, ranges, indexArrayToSearch, indexElementsRange + 1);
            }
        }

        public static int GetDecimalsCount(decimal[] arrayToSearch, decimal[][] ranges, int startIndex, int count)
        {
            if (startIndex < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex));
            }

            if (count < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(count));
            }

            if (ranges.Any(x => x?.Length > 2))
            {
                throw new ArgumentException("Invalid ranges", nameof(ranges));
            }

            if (arrayToSearch is null || ranges is null)
            {
                throw new ArgumentNullException(nameof(arrayToSearch));
            }

            for (int i = 0; i < ranges.Length; i++)
            {
                if (ranges[i] is null)
                {
                    throw new ArgumentNullException(nameof(ranges));
                }
            }

            if (startIndex + count > arrayToSearch.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(arrayToSearch));
            }

            return GetFloatsCountRecurtion(arrayToSearch, ranges, startIndex, count, 0);

            static int GetFloatsCountRecurtion(decimal[] arrayToSearch, decimal[][] ranges, int startIndex, int count, int indexElementsRange)
            {
                if (indexElementsRange >= ranges.Length)
                {
                    indexElementsRange = 0;
                    startIndex++;
                    count--;
                }

                if (startIndex >= arrayToSearch.Length || count == 0 || ranges[indexElementsRange].Length == 0)
                {
                    return 0;
                }

                if (arrayToSearch[startIndex] >= ranges[indexElementsRange][0] && arrayToSearch[startIndex] <= ranges[indexElementsRange][1] && count > 0)
                {
                    return GetFloatsCountRecurtion(arrayToSearch, ranges, startIndex + 1, count - 1, indexElementsRange) + 1;
                }

                return GetFloatsCountRecurtion(arrayToSearch, ranges, startIndex, count, indexElementsRange + 1);
            }
        }
    }
}
