using System;

namespace LearnProject.WorkingWithArrays
{
    public static class CreatingArray
    {
        public static int[] CreateEmptyArrayOfIntegers()
        {
            int[] array = Array.Empty<int>();

            return array;
        }

        public static bool[] CreateEmptyArrayOfBooleans()
        {
            bool[] array = Array.Empty<bool>();

            return array;
        }

        public static string[] CreateEmptyArrayOfStrings()
        {
            string[] array = Array.Empty<string>();

            return array;
        }

        public static char[] CreateEmptyArrayOfCharacters()
        {
            char[] array = Array.Empty<char>();

            return array;
        }

        public static double[] CreateEmptyArrayOfDoubles()
        {
            double[] array = Array.Empty<double>();

            return array;
        }

        public static float[] CreateEmptyArrayOfFloats()
        {
            float[] array = Array.Empty<float>();

            return array;
        }

        public static decimal[] CreateEmptyArrayOfDecimals()
        {
            decimal[] array = Array.Empty<decimal>();

            return array;
        }

        public static int[] CreateArrayOfTenIntegersWithDefaultValues()
        {
            int[] array = new int[10];

            return array;
        }

        public static bool[] CreateArrayOfTwentyBooleansWithDefaultValues()
        {
            bool[] array = new bool[20];

            return array;
        }

        public static string[] CreateArrayOfFiveEmptyStrings()
        {
            string[] array = new string[5];

            return array;
        }

        public static char[] CreateArrayOfFifteenCharactersWithDefaultValues()
        {
            char[] array = new char[15];

            return array;
        }

        public static double[] CreateArrayOfEighteenDoublesWithDefaultValues()
        {
            double[] array = new double[18];

            return array;
        }

        public static float[] CreateArrayOfOneHundredFloatsWithDefaultValues()
        {
            float[] array = new float[100];

            return array;
        }

        public static decimal[] CreateArrayOfOneThousandDecimalsWithDefaultValues()
        {
            decimal[] array = new decimal[1000];

            return array;
        }

        public static int[] CreateIntArrayWithOneElement()
        {
            int[] array = { 123_456 };

            return array;
        }

        public static int[] CreateIntArrayWithTwoElements()
        {
            int[] array = { 1_111_111, 9_999_999 };

            return array;
        }

        public static int[] CreateIntArrayWithTenElements()
        {
            int[] array = { 0, 4_234, 3_845, 2_942, 1_104, 9_794, 923_943, 7_537, 4_162, 10_134 };

            return array;
        }

        public static bool[] CreateBoolArrayWithOneElement()
        {
            bool[] array = { true };

            return array;
        }

        public static bool[] CreateBoolArrayWithFiveElements()
        {
            bool[] array = { true, false, true, false, true };

            return array;
        }

        public static bool[] CreateBoolArrayWithSevenElements()
        {
            bool[] array = { false, true, true, false, true, true, false };

            return array;
        }

        public static string[] CreateStringArrayWithOneElement()
        {
            string[] array = { "one" };

            return array;
        }

        public static string[] CreateStringArrayWithThreeElements()
        {
            string[] array = { "one", "two", "three" };

            return array;
        }

        public static string[] CreateStringArrayWithSixElements()
        {
            string[] array = { "one", "two", "three", "four", "five", "six" };

            return array;
        }

        public static char[] CreateCharArrayWithOneElement()
        {
            char[] array = { 'a' };

            return array;
        }

        public static char[] CreateCharArrayWithThreeElements()
        {
            char[] array = { 'a', 'b', 'c' };

            return array;
        }

        public static char[] CreateCharArrayWithNineElements()
        {
            char[] array = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'a' };

            return array;
        }

        public static double[] CreateDoubleArrayWithOneElement()
        {
            double[] array = { 1.12 };

            return array;
        }

        public static double[] CreateDoubleWithFiveElements()
        {
            double[] array = { 1.12, 2.23, 3.34, 4.45, 5.56 };

            return array;
        }

        public static double[] CreateDoubleWithNineElements()
        {
            double[] array = { 1.12, 2.23, 3.34, 4.45, 5.56, 6.67, 7.78, 8.89, 9.91 };

            return array;
        }

        public static float[] CreateFloatArrayWithOneElement()
        {
            float[] array = { 123_456_789.123456F };

            return array;
        }

        public static float[] CreateFloatWithThreeElements()
        {
            float[] array = { 1_000_000.123456F, 2_223_334_444.123456F, 9_999.999999F };

            return array;
        }

        public static float[] CreateFloatWithFiveElements()
        {
            float[] array = { 1.0123F, 20.012345F, 300.01234567F, 4_000.01234567F, 500_000.01234567F };

            return array;
        }

        public static decimal[] CreateDecimalArrayWithOneElement()
        {
            decimal[] array = { 10_000.123456M };

            return array;
        }

        public static decimal[] CreateDecimalWithFiveElements()
        {
            decimal[] array = { 1_000.1234M, 100_000.2345M, 100_000.3456M, 1_000_000.456789M, 10_000_000.5678901M };

            return array;
        }

        public static decimal[] CreateDecimalWithNineElements()
        {
            decimal[] array = { 10.122112M, 200.233223M, 3_000.344334M, 40_000.455445M, 500_000.566556M, 6_000_000.677667M, 70_000_000.788778M, 800_000_000.899889M, 9_000_000_000.911991M };

            return array;
        }
    }
}
