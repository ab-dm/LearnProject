using System;

namespace LearnProject.LookingForArrayElementsRecursion
{
    public static class IntegersCounter
    {
        public static int GetIntegersCount(int[] arrayToSearch, int[] elementsToSearchFor)
        {
            if (arrayToSearch is null)
            {
                throw new ArgumentNullException(nameof(arrayToSearch));
            }

            if (elementsToSearchFor is null)
            {
                throw new ArgumentNullException(nameof(elementsToSearchFor));
            }

            return GetIntegersCountRecurtion(arrayToSearch, elementsToSearchFor, 0, 0);

            static int GetIntegersCountRecurtion(int[] arrayToSearch, int[] elementsToSearchFor, int indexArrayToSearch, int indexElementsToSearchFor)
            {
                if (indexElementsToSearchFor >= elementsToSearchFor.Length)
                {
                    indexElementsToSearchFor = 0;
                    indexArrayToSearch++;
                }

                if (indexArrayToSearch >= arrayToSearch.Length || elementsToSearchFor.Length == 0)
                {
                    return 0;
                }

                return GetIntegersCountRecurtion(arrayToSearch, elementsToSearchFor, indexArrayToSearch, indexElementsToSearchFor + 1)
                    + ((arrayToSearch[indexArrayToSearch] == elementsToSearchFor[indexElementsToSearchFor]) ? 1 : 0);
            }
        }

        public static int GetIntegersCount(int[] arrayToSearch, int[] elementsToSearchFor, int startIndex, int count)
        {
            if (arrayToSearch is null)
            {
                throw new ArgumentNullException(nameof(arrayToSearch));
            }

            if (elementsToSearchFor is null)
            {
                throw new ArgumentNullException(nameof(elementsToSearchFor));
            }

            if (startIndex > arrayToSearch.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex));
            }

            if (startIndex < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex));
            }

            if (count < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(count));
            }

            return GetCharsCountRecurtion(arrayToSearch, elementsToSearchFor, startIndex, count, 0);

            static int GetCharsCountRecurtion(int[] arrayToSearch, int[] elementsToSearchFor, int startIndex, int count, int indexElementsToSearchFor)
            {
                if (indexElementsToSearchFor >= elementsToSearchFor.Length)
                {
                    indexElementsToSearchFor = 0;
                    startIndex++;
                    count--;
                }

                if (startIndex >= arrayToSearch.Length || elementsToSearchFor.Length == 0)
                {
                    return 0;
                }

                if (arrayToSearch[startIndex] == elementsToSearchFor[indexElementsToSearchFor] && count > 0)
                {
                    return GetCharsCountRecurtion(arrayToSearch, elementsToSearchFor, startIndex, count, indexElementsToSearchFor + 1) + 1;
                }

                return GetCharsCountRecurtion(arrayToSearch, elementsToSearchFor, startIndex, count, indexElementsToSearchFor + 1);
            }
        }
    }
}
