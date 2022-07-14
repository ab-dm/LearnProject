using System;
using System.Collections.Generic;
using System.Text;

namespace LearnProject.CountingArrayElements
{
    public class WhileMethods
    {
        public static int GetEmptyStringCount(string[] arrayToSearch)
        {
            if (arrayToSearch is null)
            {
                throw new ArgumentNullException(nameof(arrayToSearch));
            }

            int i = 0;
            int count = 0;

            while (i < arrayToSearch.Length)
            {
                if (string.IsNullOrEmpty(arrayToSearch[i]))
                {
                    count++;
                }

                i++;
            }

            return count;
        }

        public static int GetMinOrMaxLongCount(long[] arrayToSearch)
        {
            if (arrayToSearch is null)
            {
                throw new ArgumentNullException(nameof(arrayToSearch));
            }

            int i = 0;
            int count = 0;

            while (i < arrayToSearch.Length)
            {
                if (arrayToSearch[i] == long.MaxValue || arrayToSearch[i] == long.MinValue)
                {
                    count++;
                }

                i++;
            }

            return count;
        }

        public static int GetNullObjectCount(object[] arrayToSearch)
        {
            if (arrayToSearch is null)
            {
                throw new ArgumentNullException(nameof(arrayToSearch));
            }

            int i = 0;
            int count = 0;

            while (i < arrayToSearch.Length)
            {
                if (arrayToSearch[i] is null)
                {
                    count++;
                }

                i++;
            }

            return count;
        }

        public static int GetEmptyStringCountRecursive(string[] arrayToSearch)
        {
            if (arrayToSearch is null)
            {
                throw new ArgumentNullException(nameof(arrayToSearch));
            }

            if (arrayToSearch.Length == 0)
            {
                return 0;
            }

            int currentIncrement = string.IsNullOrEmpty(arrayToSearch[^1]) ? 1 : 0;
            string[] newArrayToSearch = arrayToSearch[..^1];
            return GetEmptyStringCountRecursive(newArrayToSearch) + currentIncrement;
        }

        public static int GetMinOrMaxLongCountRecursive(long[] arrayToSearch)
        {
            if (arrayToSearch is null)
            {
                throw new ArgumentNullException(nameof(arrayToSearch));
            }

            if (arrayToSearch.Length == 0)
            {
                return 0;
            }

            long currentElement = arrayToSearch[0];
            int currentIncrement = (currentElement == long.MinValue || currentElement == long.MaxValue) ? 1 : 0;
            long[] newArrayToSearch = arrayToSearch[1..];
            return GetMinOrMaxLongCountRecursive(newArrayToSearch) + currentIncrement;
        }

        public static int GetNullObjectCountRecursive(object[] arrayToSearch)
        {
            if (arrayToSearch is null)
            {
                throw new ArgumentNullException(nameof(arrayToSearch));
            }

            return GetNullObjectCountRecursive(arrayToSearch, 0);
        }

        private static int GetNullObjectCountRecursive(object[] arrayToSearch, int accumulator)
        {
            if (arrayToSearch.Length == 0)
            {
                return accumulator;
            }

            if (arrayToSearch[0] is null)
            {
                accumulator++;
            }

            object[] newArrayToSearch = arrayToSearch[1..];
            return GetNullObjectCountRecursive(newArrayToSearch, accumulator);
        }
    }
}
