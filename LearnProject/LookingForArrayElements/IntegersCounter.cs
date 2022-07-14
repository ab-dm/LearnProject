using System;

namespace LearnProject.LookingForArrayElements
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

            int result = 0;
            for (int i = 0; i < elementsToSearchFor.Length; i++)
            {
                for (int j = 0; j < arrayToSearch.Length; j++)
                {
                    if (elementsToSearchFor[i] == arrayToSearch[j])
                    {
                        result++;
                    }
                }
            }

            return result;
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

            int result = 0;
            for (int i = startIndex; i < arrayToSearch.Length && i < startIndex + count; i++)
            {
                for (int j = 0; j < elementsToSearchFor.Length; j++)
                {
                    if (elementsToSearchFor[j] == arrayToSearch[i])
                    {
                        result++;
                    }
                }
            }

            return result;
        }
    }
}
