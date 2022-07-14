﻿using System;

namespace LearnProject.CountingArrayElements
{
    public class DoWhileMethods
    {
        public static int GetFalseValueCount(bool[] arrayToSearch)
        {
            if (arrayToSearch is null)
            {
                throw new ArgumentNullException(nameof(arrayToSearch));
            }

            int i = 0;
            int cont = 0;

            do
            {
                if (arrayToSearch[i] == false)
                {
                    cont++;
                }

                i++;
            }
            while (arrayToSearch.Length > i);

            return cont;
        }

        public static int GetZeroDecimalCount(decimal[] arrayToSearch)
        {
            if (arrayToSearch is null)
            {
                throw new ArgumentNullException(nameof(arrayToSearch));
            }

            int i = 0;
            int cont = 0;

            do
            {
                if (arrayToSearch[i] == 0)
                {
                    cont++;
                }

                i++;
            }
            while (arrayToSearch.Length > i);

            return cont;
        }

        public static int GetRoundedToEvenCount(double[] arrayToSearch)
        {
            if (arrayToSearch is null)
            {
                throw new ArgumentNullException(nameof(arrayToSearch));
            }

            int i = 0;
            int cont = 0;

            do
            {
                if (Math.Round(arrayToSearch[i]) % 2 == 0)
                {
                    cont++;
                }

                i++;
            }
            while (arrayToSearch.Length > i);

            return cont;
        }

        public static int GetFalseValueCountRecursive(bool[] arrayToSearch)
        {
            if (arrayToSearch is null)
            {
                throw new ArgumentNullException(nameof(arrayToSearch));
            }

            return GetFalseValueCountRecursive(arrayToSearch, arrayToSearch.Length, 0);
        }

        public static int GetZeroDecimalCountRecursive(decimal[] arrayToSearch)
        {
            if (arrayToSearch is null)
            {
                throw new ArgumentNullException(nameof(arrayToSearch));
            }

            if (arrayToSearch.Length == 0)
            {
                return 0;
            }

            int middleIndex = arrayToSearch.Length / 2;
            decimal[] leftArrayToSearch = arrayToSearch[..middleIndex];
            decimal[] rightArrayToSearch = arrayToSearch[middleIndex..];

            int leftArrayCount = GetZeroDecimalCountRecursive(leftArrayToSearch, 0);
            int rightArrayCount = GetZeroDecimalCountRecursive(rightArrayToSearch, 0);

            return leftArrayCount + rightArrayCount;
        }

        public static int GetRoundedToEvenCountRecursive(double[] arrayToSearch)
        {
            if (arrayToSearch is null)
            {
                throw new ArgumentNullException(nameof(arrayToSearch));
            }

            static int ProcessArray(double[] array)
            {
                if (array.Length <= 0)
                {
                    return 0;
                }

                double currentElement = array[0];
                int currentIncrement = 0;
                bool isElementNearEvenNumber = (Math.Round(currentElement, MidpointRounding.ToEven) % 2) == 0;

                if (isElementNearEvenNumber)
                {
                    currentIncrement++;
                }

                if (array.Length > 1)
                {
                    return GetRoundedToEvenCountRecursive(array[1..]) + currentIncrement;
                }

                return currentIncrement;
            }

            static int GetRoundedToEvenCountRecursive(double[] array)
            {
                if (array.Length == 0)
                {
                    return 0;
                }

                int middleIndex = array.Length / 2;
                double[] leftArrayToSearch = array[..middleIndex];
                double[] rightArrayToSearch = array[middleIndex..];

                return ProcessArray(leftArrayToSearch) + ProcessArray(rightArrayToSearch);
            }

            return GetRoundedToEvenCountRecursive(arrayToSearch);
        }

        private static int GetFalseValueCountRecursive(bool[] arrayToSearch, int elementsLeft, int accumulator)
        {
            if (elementsLeft > 0)
            {
                accumulator = !arrayToSearch[^elementsLeft] ? ++accumulator : accumulator;
                return GetFalseValueCountRecursive(arrayToSearch, --elementsLeft, accumulator);
            }

            return accumulator;
        }

        private static int GetZeroDecimalCountRecursive(decimal[] arrayToSearch, int accumulator)
        {
            if (arrayToSearch.Length == 0)
            {
                return accumulator;
            }

            if (arrayToSearch[0] == decimal.Zero)
            {
                accumulator++;
            }

            return GetZeroDecimalCountRecursive(arrayToSearch[1..], accumulator);
        }
    }
}
