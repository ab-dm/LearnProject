﻿using System;

namespace LearnProject.CountingArrayElements
{
    public class ForMethods
    {
        public static int GetNegativeIntegerCount(int[] arrayToSearch)
        {
            if (arrayToSearch is null)
            {
                throw new ArgumentNullException(nameof(arrayToSearch));
            }

            int negetiveCount = 0;

            for (int i = 0; i < arrayToSearch.Length; i++)
            {
                if (arrayToSearch[i] < 0)
                {
                    negetiveCount++;
                }
            }

            return negetiveCount;
        }

        public static int GetEvenNumberCount(float[] arrayToSearch)
        {
            if (arrayToSearch is null)
            {
                throw new ArgumentNullException(nameof(arrayToSearch));
            }

            int evenNumbersCount = 0;

            for (int i = 0; i < arrayToSearch.Length; i++)
            {
                if (arrayToSearch[i] % 2 == 0)
                {
                    evenNumbersCount++;
                }
            }

            return evenNumbersCount;
        }

        public static int GetByteWithBitsInHighNibbleCount(byte[] arrayToSearch)
        {
            if (arrayToSearch is null)
            {
                throw new ArgumentNullException(nameof(arrayToSearch));
            }

            int count = 0;

            for (int i = 0; i < arrayToSearch.Length; i++)
            {
                if (arrayToSearch[i] > 15)
                {
                    count++;
                }
            }

            return count;
        }

        public static int GetNegativeIntegerCountRecursive(int[] arrayToSearch)
        {
            if (arrayToSearch is null)
            {
                throw new ArgumentNullException(nameof(arrayToSearch));
            }

            return GetNegativeIntegerCountRecursive(arrayToSearch, 0);
        }

        public static int GetEvenNumberCountRecursive(float[] arrayToSearch)
        {
            if (arrayToSearch is null)
            {
                throw new ArgumentNullException(nameof(arrayToSearch));
            }

            if (arrayToSearch.Length == 0)
            {
                return 0;
            }

            int currentIncrement = arrayToSearch[0] % 2 == 0 ? 1 : 0;
            return GetEvenNumberCountRecursive(arrayToSearch[1..]) + currentIncrement;
        }

        public static int GetByteWithBitsInHighNibbleCountRecursive(byte[] arrayToSearch)
        {
            if (arrayToSearch is null)
            {
                throw new ArgumentNullException(nameof(arrayToSearch));
            }

            return GetByteWithBitsInHighNibbleCountRecursive(arrayToSearch, arrayToSearch.Length - 1, 0);
        }

        private static int GetNegativeIntegerCountRecursive(int[] arrayToSearch, int index)
        {
            if (index >= arrayToSearch.Length)
            {
                return 0;
            }

            int currentIncrement = arrayToSearch[index] < 0 ? 1 : 0;
            return GetNegativeIntegerCountRecursive(arrayToSearch, index + 1) + currentIncrement;
        }

        private static int GetByteWithBitsInHighNibbleCountRecursive(byte[] arrayToSearch, int index, int accumulator)
        {
            if (index < 0)
            {
                return accumulator;
            }

            int currentAccumulator = (arrayToSearch[index] & 0xF0) > 0 ? accumulator + 1 : accumulator;
            return GetByteWithBitsInHighNibbleCountRecursive(arrayToSearch, --index, currentAccumulator);
        }
    }
}
