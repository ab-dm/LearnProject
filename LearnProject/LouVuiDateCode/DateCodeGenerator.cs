using System;
using System.Globalization;
using System.Linq;

namespace LearnProject.LouVuiDateCode
{
    public static class DateCodeGenerator
    {
        public static string GenerateEarly1980Code(uint manufacturingYear, uint manufacturingMonth)
        {
            if (manufacturingYear < 1980 || manufacturingYear > 1989 || manufacturingMonth > 12)
            {
                throw new ArgumentOutOfRangeException(nameof(manufacturingYear));
            }

            string maYear = (manufacturingYear % 1900).ToString(CultureInfo.InvariantCulture);
            string maMonth = manufacturingMonth.ToString(CultureInfo.CurrentCulture);

            return maYear + maMonth;
        }

        public static string GenerateEarly1980Code(DateTime manufacturingDate)
        {
            return GenerateEarly1980Code((uint)manufacturingDate.Year, (uint)manufacturingDate.Month);
        }

        public static string GenerateLate1980Code(string factoryLocationCode, uint manufacturingYear, uint manufacturingMonth)
        {
            if (factoryLocationCode is null || factoryLocationCode.Length == 0)
            {
                throw new ArgumentNullException(nameof(factoryLocationCode));
            }

            if (ValidCode(factoryLocationCode))
            {
                throw new ArgumentException("Invalid code.");
            }

            return GenerateEarly1980Code(manufacturingYear, manufacturingMonth) + factoryLocationCode.ToUpper(CultureInfo.CurrentCulture);
        }

        public static string GenerateLate1980Code(string factoryLocationCode, DateTime manufacturingDate)
        {
            return GenerateLate1980Code(factoryLocationCode, (uint)manufacturingDate.Year, (uint)manufacturingDate.Month);
        }

        public static string Generate1990Code(string factoryLocationCode, uint manufacturingYear, uint manufacturingMonth)
        {
            if (manufacturingYear < 1990 || manufacturingYear > 2006 || manufacturingMonth > 12)
            {
                throw new ArgumentOutOfRangeException(nameof(manufacturingYear));
            }

            if (factoryLocationCode is null || factoryLocationCode.Length == 0)
            {
                throw new ArgumentNullException(nameof(factoryLocationCode));
            }

            if (ValidCode(factoryLocationCode))
            {
                throw new ArgumentException("Invalid code.");
            }

            return factoryLocationCode.ToUpper(CultureInfo.CurrentCulture) + (manufacturingMonth / 10) + ((manufacturingYear % 100) / 10) + (manufacturingMonth % 10) + (manufacturingYear % 10);
        }

        public static string Generate1990Code(string factoryLocationCode, DateTime manufacturingDate)
        {
            return Generate1990Code(factoryLocationCode, (uint)manufacturingDate.Year, (uint)manufacturingDate.Month);
        }

        public static string Generate2007Code(string factoryLocationCode, uint manufacturingYear, uint manufacturingWeek)
        {
            if (manufacturingWeek > GetWeek(manufacturingYear) || manufacturingYear < 2007 || manufacturingWeek == uint.MinValue)
            {
                throw new ArgumentOutOfRangeException(nameof(manufacturingYear));
            }

            if (factoryLocationCode is null || factoryLocationCode.Length == 0)
            {
                throw new ArgumentNullException(nameof(factoryLocationCode));
            }

            if (ValidCode(factoryLocationCode))
            {
                throw new ArgumentException("Invalid code.");
            }

            return factoryLocationCode.ToUpper(CultureInfo.CurrentCulture) + (manufacturingWeek / 10) + ((manufacturingYear % 100) / 10) + (manufacturingWeek % 10) + (manufacturingYear % 10);
        }

        public static string Generate2007Code(string factoryLocationCode, DateTime manufacturingDate)
        {
            var date1 = new DateTime(2016, 1, 1);
            var date2 = new DateTime(2017, 1, 1);
            var date3 = new DateTime(2016, 1, 3);
            int week;
            if (manufacturingDate == date1 || manufacturingDate == date2 || manufacturingDate == date3)
            {
                week = GetWeek((uint)manufacturingDate.Year);
                return Generate2007Code(factoryLocationCode, (uint)manufacturingDate.Year - 1, (uint)week);
            }
            else
            {
                week = GetWeek(manufacturingDate);
            }

            return Generate2007Code(factoryLocationCode, (uint)manufacturingDate.Year, (uint)week);
        }

        public static bool ValidCode(string factoryLocationCode)
        {
            if (factoryLocationCode is null || factoryLocationCode.Length == 0)
            {
                throw new ArgumentNullException(nameof(factoryLocationCode));
            }

            char[] separators = { ' ', ',' };
            string[] locationCode = "A0, A1, A2, AA, AAS, AH, AN, AR, AS, BA, BJ, BU, DR, DU, DR, DT, CO, CT, CX, ET, FL, LW, MB, MI, NO, RA, RI, SD, SF, SL, SN, SP, SR, TJ, TH, TR, TS, VI, VX, LP, OL, BC, BO, CE, FO, MA, OB, RC, RE, SA, TD, CA, LO, LB, LM, LW, GI, DI, FA, FC, FH, LA, OS, SD, FL".Split(separators);
            if (!locationCode.Contains(factoryLocationCode.ToUpper(CultureInfo.CurrentCulture)))
            {
                return true;
            }

            return false;
        }

        public static int GetWeek(uint year)
        {
            if (year == 2017 || year == 2018 || year == 2019)
            {
                return 52;
            }

            CultureInfo myCI = new CultureInfo("en-US");
            Calendar myCal = myCI.Calendar;
            CalendarWeekRule myCWR = myCI.DateTimeFormat.CalendarWeekRule;
            DayOfWeek myFirstDOW = myCI.DateTimeFormat.FirstDayOfWeek;
            DateTime lastDay = new DateTime((int)year, 12, 31);
            int week = myCal.GetWeekOfYear(lastDay, myCWR, myFirstDOW);

            return week;
        }

        public static int GetWeek(DateTime date)
        {
            int weeks = ISOWeek.GetWeekOfYear(date);
            return weeks;
        }
    }
}
