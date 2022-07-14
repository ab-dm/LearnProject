using System;

namespace LearnProject.ParsingStrings
{
    public static class NumberParser
    {
        public static bool TryParseInteger(string str, out int result)
        {
            return int.TryParse(str, out result);
        }

        public static int ParseInteger(string str)
        {
            try
            {
                return int.Parse(str);
            }
            catch (FormatException)
            {
                return 0;
            }
            catch (OverflowException)
            {
                return -1;
            }
        }

        public static bool TryParseUnsignedInteger(string str, out uint result)
        {
            return uint.TryParse(str, out result);
        }

        public static uint ParseUnsignedInteger(string str)
        {
            try
            {
                return uint.Parse(str);
            }
            catch (FormatException)
            {
                return 0;
            }
            catch (OverflowException)
            {
                return uint.MaxValue;
            }
        }

        public static bool TryParseByte(string str, out byte result)
        {
            return byte.TryParse(str, out result);
        }

        public static byte ParseByte(string str)
        {
            try
            {
                return byte.Parse(str);
            }
            catch (FormatException)
            {
                return byte.MaxValue;
            }
            catch (OverflowException)
            {
                return byte.MinValue;
            }
        }

        public static bool TrySignedByte(string str, out sbyte result)
        {
            return sbyte.TryParse(str, out result);
        }

        public static sbyte ParseSignedByte(string str)
        {
            try
            {
                return sbyte.Parse(str);
            }
            catch (FormatException)
            {
                return sbyte.MaxValue;
            }
            catch (OverflowException)
            {
                return sbyte.Parse(str);
            }
        }

        public static bool TryParseShort(string str, out short result)
        {
            return short.TryParse(str, out result);
        }

        public static short ParseShort(string str)
        {
            try
            {
                return short.Parse(str);
            }
            catch (FormatException)
            {
                return short.Parse(str);
            }
            catch (OverflowException)
            {
                return short.Parse(str);
            }
        }

        public static bool TryParseUnsignedShort(string str, out ushort result)
        {
            return ushort.TryParse(str, out result);
        }

        public static ushort ParseUnsignedShort(string str)
        {
            try
            {
                return ushort.Parse(str);
            }
            catch (FormatException)
            {
                return ushort.MinValue;
            }
            catch (OverflowException)
            {
                return ushort.MaxValue;
            }
        }

        public static bool TryParseLong(string str, out long result)
        {
            return long.TryParse(str, out result);
        }

        public static long ParseLong(string str)
        {
            try
            {
                return long.Parse(str);
            }
            catch (FormatException)
            {
                return long.MinValue;
            }
            catch (OverflowException)
            {
                return -1;
            }
        }

        public static bool TryParseUnsignedLong(string str, out ulong result)
        {
            return ulong.TryParse(str, out result);
        }

        public static ulong ParseUnsignedLong(string str)
        {
            try
            {
                return ulong.Parse(str);
            }
            catch (FormatException)
            {
                return ulong.Parse(str);
            }
            catch (OverflowException)
            {
                return ulong.Parse(str);
            }
        }
    }
}
