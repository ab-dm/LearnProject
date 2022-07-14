using LouVuiDateCode;
using System;
using System.Globalization;

namespace LearnProject.LouVuiDateCode
{
    public static class DateCodeParser
    {
        public static void ParseEarly1980Code(string dateCode, out uint manufacturingYear, out uint manufacturingMonth)
        {
            if (dateCode is null || dateCode.Length == 0)
            {
                throw new ArgumentNullException(nameof(dateCode));
            }

            int dateCodeDate = Convert.ToInt32(dateCode, CultureInfo.CurrentCulture);

            manufacturingYear = 1900u + ((uint)dateCodeDate / 100);
            manufacturingMonth = (uint)dateCodeDate % 100;

            if (dateCode.Length == 3)
            {
                manufacturingYear = 1900u + ((uint)dateCodeDate / 10);
                manufacturingMonth = (uint)dateCodeDate % 10;
            }

            if (manufacturingYear < 1980 || manufacturingYear > 1989 || manufacturingMonth > 12 || manufacturingMonth <= 0)
            {
                throw new ArgumentException("Invalid code.");
            }
        }

        public static void ParseLate1980Code(string dateCode, out Country[] factoryLocationCountry, out string factoryLocationCode, out uint manufacturingYear, out uint manufacturingMonth)
        {
            if (dateCode is null || dateCode.Length == 0)
            {
                throw new ArgumentNullException(nameof(dateCode));
            }

            factoryLocationCode = dateCode[^2..];

            if (DateCodeGenerator.ValidCode(factoryLocationCode))
            {
                throw new ArgumentException("Invalid code.");
            }

            dateCode = dateCode.Remove(dateCode.Length - 2, 2);
            ParseEarly1980Code(dateCode, out manufacturingYear, out manufacturingMonth);

            factoryLocationCountry = CountryParser.GetCountry(factoryLocationCode);
        }

        public static void Parse1990Code(string dateCode, out Country[] factoryLocationCountry, out string factoryLocationCode, out uint manufacturingYear, out uint manufacturingMonth)
        {
            if (dateCode is null || dateCode.Length == 0)
            {
                throw new ArgumentNullException(nameof(dateCode));
            }

            factoryLocationCode = dateCode[0..2];

            if (DateCodeGenerator.ValidCode(factoryLocationCode))
            {
                throw new ArgumentException("Invalid code.");
            }

            factoryLocationCountry = CountryParser.GetCountry(factoryLocationCode);
            dateCode = dateCode[2..];
            string year;

            if (dateCode[1] == '0')
            {
                year = "20" + dateCode[1] + dateCode[^1];
            }
            else
            {
                year = "19" + dateCode[1] + dateCode[^1];
            }

            string month = string.Empty + dateCode[0] + dateCode[2];

            manufacturingYear = Convert.ToUInt32(year, CultureInfo.CurrentCulture);
            manufacturingMonth = Convert.ToUInt32(month, CultureInfo.CurrentCulture);

            if (manufacturingYear < 1990 || manufacturingYear > 2006 || manufacturingMonth > 12 || manufacturingMonth <= 0 || dateCode.Length > 4)
            {
                throw new ArgumentException("Invalid code.", nameof(dateCode));
            }
        }

        public static void Parse2007Code(string dateCode, out Country[] factoryLocationCountry, out string factoryLocationCode, out uint manufacturingYear, out uint manufacturingWeek)
        {
            if (dateCode is null || dateCode.Length == 0)
            {
                throw new ArgumentNullException(nameof(dateCode));
            }

            factoryLocationCode = dateCode[0..2];

            if (DateCodeGenerator.ValidCode(factoryLocationCode))
            {
                throw new ArgumentException("Invalid code.");
            }

            factoryLocationCountry = CountryParser.GetCountry(factoryLocationCode);
            dateCode = dateCode[2..];
            string year = "20" + dateCode[1] + dateCode[^1];

            string month = string.Empty + dateCode[0] + dateCode[2];

            manufacturingYear = Convert.ToUInt32(year, CultureInfo.CurrentCulture);
            manufacturingWeek = Convert.ToUInt32(month, CultureInfo.CurrentCulture);

            if (manufacturingWeek > DateCodeGenerator.GetWeek(manufacturingYear) || manufacturingYear < 2007 || manufacturingWeek == uint.MinValue)
            {
                throw new ArgumentException("Invalid code.");
            }
        }
    }
}
