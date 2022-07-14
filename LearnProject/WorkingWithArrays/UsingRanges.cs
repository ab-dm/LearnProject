using System;

namespace LearnProject.WorkingWithArrays
{
    public static class UsingRanges
    {
        public static int[] GetArrayWithAllElements(int[] array)
        {
            int[] resArray = new int[array.Length];

            Array.Copy(array, resArray, array.Length);

            return resArray;
        }

        public static int[] GetArrayWithoutFirstElement(int[] array)
        {
            int[] resArray = new int[array.Length - 1];

            Array.Copy(array, 1, resArray, 0, array.Length - 1);

            return resArray;
        }

        public static int[] GetArrayWithoutTwoFirstElements(int[] array)
        {
            int[] resArray = new int[array.Length - 2];

            Array.Copy(array, 2, resArray, 0, array.Length - 2);

            return resArray;
        }

        public static int[] GetArrayWithoutThreeFirstElements(int[] array)
        {
            int[] resArray = new int[array.Length - 3];

            Array.Copy(array, 3, resArray, 0, array.Length - 3);

            return resArray;
        }

        public static int[] GetArrayWithoutLastElement(int[] array)
        {
            int[] resArray = new int[array.Length - 1];

            Array.Copy(array, 0, resArray, 0, array.Length - 1);

            return resArray;
        }

        public static int[] GetArrayWithoutTwoLastElements(int[] array)
        {
            int[] resArray = new int[array.Length - 2];

            Array.Copy(array, 0, resArray, 0, array.Length - 2);

            return resArray;
        }

        public static int[] GetArrayWithoutThreeLastElements(int[] array)
        {
            int[] resArray = new int[array.Length - 3];

            Array.Copy(array, 0, resArray, 0, array.Length - 3);

            return resArray;
        }

        public static bool[] GetArrayWithoutFirstAndLastElements(bool[] array)
        {
            bool[] resArray = new bool[array.Length - 2];

            Array.Copy(array, 1, resArray, 0, array.Length - 2);

            return resArray;
        }

        public static bool[] GetArrayWithoutTwoFirstAndTwoLastElements(bool[] array)
        {
            bool[] resArray = new bool[array.Length - 4];

            Array.Copy(array, 2, resArray, 0, array.Length - 4);

            return resArray;
        }

        public static bool[] GetArrayWithoutThreeFirstAndThreeLastElements(bool[] array)
        {
            bool[] resArray = new bool[array.Length - 6];

            Array.Copy(array, 3, resArray, 0, array.Length - 6);

            return resArray;
        }
    }
}
