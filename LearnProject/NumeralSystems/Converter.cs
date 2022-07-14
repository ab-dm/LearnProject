using System;

namespace LearnProject.NumeralSystems
{
    public static class Converter
    {
        public static string GetPositiveOctal(this int number) =>
            number < 0 ? throw new ArgumentException($"{nameof(number)} can not be less than zero.")
            : GetRadix(number, 8);

        public static string GetPositiveDecimal(this int number) =>
            number < 0 ? throw new ArgumentException($"{nameof(number)} can not be less than zero.")
            : GetRadix(number, 10);

        public static string GetPositiveHex(this int number) =>
            number < 0 ? throw new ArgumentException($"{nameof(number)} can not be less than zero.")
            : GetRadix(number, 16);

        public static string GetPositiveRadix(this int number, int radix)
        {
            if (number < 0)
            {
                throw new ArgumentException($"{nameof(number)} can not be less than zero.");
            }

            if (radix != 8 && radix != 10 && radix != 16)
            {
                throw new ArgumentException($"{nameof(radix)} can not be less than zero.");
            }

            string result = string.Empty;
            uint temp = (uint)number;
            while (temp >= radix)
            {
                result = ByteHex((byte)(temp % radix)).ToString() + result;
                temp = (uint)(temp / radix);
            }

            result = ByteHex((byte)(temp % radix)).ToString() + result;
            return result;
        }

        public static string GetRadix(this int number, int radix)
        {
            if (radix != 8 && radix != 10 && radix != 16)
            {
                throw new ArgumentException($"{nameof(radix)} can not be less than zero.");
            }

            string result = string.Empty;
            uint temp = (uint)number;
            while (temp >= radix)
            {
                result = ByteHex((byte)(temp % radix)).ToString() + result;
                temp = (uint)(temp / radix);
            }

            result = ByteHex((byte)(temp % radix)).ToString() + result;
            return result;
        }

        public static char ByteHex(byte number)
        {
            char result;
            byte temp = (byte)(number & 0x0F);
            switch (temp)
            {
                case 15:
                    result = 'F';
                    break;
                case 14:
                    result = 'E';
                    break;
                case 13:
                    result = 'D';
                    break;
                case 12:
                    result = 'C';
                    break;
                case 11:
                    result = 'B';
                    break;
                case 10:
                    result = 'A';
                    break;
                default:
                    result = (char)('0' + temp);
                    break;
            }

            return result;
        }
    }
}
