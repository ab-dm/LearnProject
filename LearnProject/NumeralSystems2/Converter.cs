using System;
using System.Globalization;

namespace LearnProject.NumeralSystems2
{
    public static class Converter
    {
        public static int ParsePositiveFromOctal(this string source) =>
            ParsePositiveByRadix(source, 8);

        public static int ParsePositiveFromDecimal(this string source) =>
            ParsePositiveByRadix(source, 10);

        public static int ParsePositiveFromHex(this string source) =>
            ParsePositiveByRadix(source, 16);

        public static int ParsePositiveByRadix(this string source, int radix)
        {
            int result = ParseByRadix(source, radix);
            if (result < 0)
            {
                throw new ArgumentException("does not represent a positive number in numeral system.");
            }

            return result;
        }

        public static int ParseByRadix(this string source, int radix)
        {
            if (string.IsNullOrEmpty(source))
            {
                throw new ArgumentException("Source is empty!");
            }

            var charSource = source.ToUpper(CultureInfo.CurrentCulture).ToCharArray();
            ExeptionSource(charSource, radix);

            var digits = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };

            int resultNumber = 0;
            int factorial = 1;
            for (int i = charSource.Length - 1; i >= 0; i--)
            {
                for (int j = 0; j < digits.Length; j++)
                {
                    if (charSource[i] == digits[j])
                    {
                        resultNumber += j * factorial;
                        factorial *= radix;
                    }
                }

                if (charSource[i] == '-')
                {
                    resultNumber *= -1;
                }
            }

            return resultNumber;
        }

        public static bool TryParsePositiveFromOctal(this string source, out int value) =>
            TryParsePositiveByRadix(source, 8, out value);

        public static bool TryParsePositiveFromDecimal(this string source, out int value) =>
            TryParsePositiveByRadix(source, 10, out value);

        public static bool TryParsePositiveFromHex(this string source, out int value) =>
            TryParsePositiveByRadix(source, 16, out value);

        public static bool TryParsePositiveByRadix(this string source, int radix, out int value)
        {
            bool result = true;
            if (radix != 8 && radix != 10 && radix != 16)
            {
                throw new ArgumentException(nameof(radix).ToString());
            }

            value = 0;
            try
            {
                value = ParsePositiveByRadix(source, radix);
            }
            catch (Exception)
            {
                result = false;
            }

            return result;
        }

        public static bool TryParseByRadix(this string source, int radix, out int value)
        {
            bool result = true;
            value = 0;
            try
            {
                value = ParseByRadix(source, radix);
            }
            catch (Exception)
            {
                result = false;
            }

            return result;
        }

        private static void ExeptionSource(char[] charSource, int radix)
        {
            if (radix != 8 && radix != 10 && radix != 16)
            {
                throw new ArgumentException("radix is not equal 8, 10 or 16.");
            }

            var digits = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };

            foreach (var item in charSource)
            {
                if (item == '-')
                {
                    continue;
                }

                var digitAlphabetIndex = Array.IndexOf(digits, item);

                if (digitAlphabetIndex == -1 || digitAlphabetIndex >= radix)
                {
                    throw new ArgumentException("(source) does not represent a signed number in the octal, decimal or hex numeral system.");
                }
            }
        }
    }
}
