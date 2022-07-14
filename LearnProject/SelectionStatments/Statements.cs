using System;

namespace LearnProject.SelectionStatments
{
    public static class Statements
    {
        public static void WriteLargestWithNestedIfElse(int first, int second, int third)
        {
            if (first > second && first > third)
            {
                Console.WriteLine($"Number {first} is the largest");
            }
            else if (second > first && second > third)
            {
                Console.WriteLine($"Number {second} is the largest");
            }
            else
            {
                Console.WriteLine($"Number {third} is the largest");
            }
        }

        public static void WriteLargestWithIfElseAndTernaryOperator(int first, int second, int third)
        {
            if (first > third && second > third)
            {
                Console.WriteLine((first > second) ? $"Number {first} is the largest" : $"Number {second} is the largest");
            }
            else if (third > first && second > first)
            {
                Console.WriteLine((third > second) ? $"Number {third} is the largest" : $"Number {second} is the largest");
            }
            else if (third > second && first > second)
            {
                Console.WriteLine((third > first) ? $"Number {third} is the largest" : $"Number {first} is the largest");
            }
        }

        public static void WriteLargestWithIfElseAndConditionLogicalOperators(int first, int second, int third)
        {
            if (first > third & first > second)
            {
                Console.WriteLine($"Number {first} is the largest");
            }
            else if (second > first & second > third)
            {
                Console.WriteLine($"Number {second} is the largest");
            }
            else if (third > first & third > second)
            {
                Console.WriteLine($"Number {third} is the largest");
            }
        }

        public static void HowOldAreYouReactionWithCascadedIfElse(int userAge)
        {
            if (userAge >= 65)
            {
                Console.WriteLine("Enjoy your retirement!");
            }
            else if (userAge >= 21)
            {
                Console.WriteLine("Fancy an alcoholic beverage?");
            }
            else if (userAge >= 18)
            {
                Console.WriteLine("You're old enough to drive.");
            }
            else
            {
                Console.WriteLine("You are too young to drive, drink, or retire.");
            }
        }

        public static void WriteInformationAboutDailyDownloadsWithCascadedIfElse(int countOfDailyDownloads)
        {
            if (countOfDailyDownloads <= 0)
            {
                Console.WriteLine("No downloads.");
            }
            else if (countOfDailyDownloads < 100)
            {
                Console.WriteLine("Daily downloads: 1-100.");
            }
            else if (countOfDailyDownloads < 1000)
            {
                Console.WriteLine("Daily downloads: 100-1,000.");
            }
            else if (countOfDailyDownloads < 10000)
            {
                Console.WriteLine("Daily downloads: 1,000-10,000.");
            }
            else if (countOfDailyDownloads < 100000)
            {
                Console.WriteLine("Daily downloads: 10,000-100,000.");
            }
            else
            {
                Console.WriteLine("Daily downloads: 100,000+.");
            }
        }

        public static void WriteTheInformationAboutDayWithIfElse(DayOfWeek dayOfWeek)
        {
            if (dayOfWeek == DayOfWeek.Sunday || dayOfWeek == DayOfWeek.Saturday)
            {
                Console.WriteLine("The weekend.");
            }
            else if (dayOfWeek == DayOfWeek.Monday)
            {
                Console.WriteLine("The first day of the work week.");
            }
            else if (dayOfWeek == DayOfWeek.Friday)
            {
                Console.WriteLine("The last day of the work week.");
            }
            else
            {
                Console.WriteLine("The middle of the work week.");
            }
        }

        public static void WriteTheInformationAboutDayWithSwitchStatement(DayOfWeek dayOfWeek)
        {
            switch (dayOfWeek)
            {
                case DayOfWeek.Sunday:
                case DayOfWeek.Saturday:
                    Console.WriteLine("The weekend.");
                    break;
                case DayOfWeek.Monday:
                    Console.WriteLine("The first day of the work week.");
                    break;
                case DayOfWeek.Tuesday:
                case DayOfWeek.Wednesday:
                case DayOfWeek.Thursday:
                    Console.WriteLine("The middle of the work week.");
                    break;
                case DayOfWeek.Friday:
                    Console.WriteLine("The last day of the work week.");
                    break;
                default:
                    break;
            }
        }

        public static string GetTypeOfIntegerWithCascadedIfElse(object arg)
        {
            if (arg is sbyte)
            {
                return $"{arg} is sbyte.";
            }
            else if (arg is byte)
            {
                return $"{arg} is byte.";
            }
            else if (arg is short)
            {
                return $"{arg} is short.";
            }
            else if (arg is int)
            {
                return $"{arg} is int.";
            }
            else if (arg is long)
            {
                return $"{arg} is long.";
            }
            else if (arg is ushort)
            {
                return $"{arg} is ushort.";
            }
            else if (arg is uint)
            {
                return $"{arg} is uint.";
            }
            else if (arg is ulong)
            {
                return $"{arg} is ulong.";
            }
            else
            {
                return $"{arg} is not integer.";
            }
        }

        public static string GetTypeOfIntegerWithSwitchStatement(object arg)
        {
            string result = arg switch
            {
                sbyte _ => $"{arg} is sbyte.",
                byte _ => $"{arg} is byte.",
                short _ => $"{arg} is short.",
                int _ => $"{arg} is int.",
                long _ => $"{arg} is long.",
                ushort _ => $"{arg} is ushort.",
                uint _ => $"{arg} is uint.",
                ulong _ => $"{arg} is ulong.",
                _ => $"{arg} is not integer.",
            };
            return result;
        }

        public static string GetTypeOfIntegerWithSwitchExpression(object arg) => arg switch
        {
            sbyte _ => $"{arg} is sbyte.",
            byte _ => $"{arg} is byte.",
            short _ => $"{arg} is short.",
            int _ => $"{arg} is int.",
            long _ => $"{arg} is long.",
            ushort _ => $"{arg} is ushort.",
            uint _ => $"{arg} is uint.",
            ulong _ => $"{arg} is ulong.",
            _ => $"{arg} is not integer.",
        };

        public static void WriteTheInformationAboutSeasonsWithSwitchStatement(Month month)
        {
            switch (month)
            {
                case Month.December:
                case Month.January:
                case Month.February:
                    Console.WriteLine("It's winter now.");
                    break;
                case Month.March:
                case Month.April:
                case Month.May:
                    Console.WriteLine("It's spring now.");
                    break;
                case Month.June:
                case Month.July:
                case Month.August:
                    Console.WriteLine("It's summer now.");
                    break;
                case Month.September:
                case Month.October:
                case Month.November:
                    Console.WriteLine("It's autumn now.");
                    break;
                default:
                    Console.WriteLine("Sorry, the month was entered incorrectly.");
                    break;
            }
        }

        public static byte GetLengthWithCascadedIfElse(int number)
        {
            if (number > -10 && number < 10)
            {
                return 1;
            }
            else if (number > -100 && number < 100)
            {
                return 2;
            }
            else if (number > -1_000 && number < 1_000)
            {
                return 3;
            }
            else if (number > -10_000 && number < 10_000)
            {
                return 4;
            }
            else if (number > -100_000 && number < 100_000)
            {
                return 5;
            }
            else if (number > -1_000_000 && number < 1_000_000)
            {
                return 6;
            }
            else if (number > -10_000_000 && number < 10_000_000)
            {
                return 7;
            }
            else if (number > -100_000_000 && number < 100_000_000)
            {
                return 8;
            }
            else if (number > -1_000_000_000 && number < 1_000_000_000)
            {
                return 9;
            }
            else if (number >= int.MinValue && number <= int.MaxValue)
            {
                return 10;
            }
            else
            {
                return 0;
            }
        }

        public static byte GetLengthWithSwitchExpression(int number) => number switch
        {
            _ when number > -10 && number < 10 => 1,
            _ when number > -100 && number < 100 => 2,
            _ when number > -1_000 && number < 1_000 => 3,
            _ when number > -10_000 && number < 10_000 => 4,
            _ when number > -100_000 && number < 100_000 => 5,
            _ when number > -1_000_000 && number < 1_000_000 => 6,
            _ when number > -10_000_000 && number < 10_000_000 => 7,
            _ when number > -100_000_000 && number < 100_000_000 => 8,
            _ when number > -1_000_000_000 && number < 1_000_000_000 => 9,
            _ when number >= int.MinValue && number <= int.MaxValue => 10,
            _ => 0,
        };

        public static Month? GetMonthWithCascadedIfElse(int month)
        {
            if (month == 1)
            {
                return Month.January;
            }
            else if (month == 2)
            {
                return Month.February;
            }
            else if (month == 3)
            {
                return Month.March;
            }
            else if (month == 4)
            {
                return Month.April;
            }
            else if (month == 5)
            {
                return Month.May;
            }
            else if (month == 6)
            {
                return Month.June;
            }
            else if (month == 7)
            {
                return Month.July;
            }
            else if (month == 8)
            {
                return Month.August;
            }
            else if (month == 9)
            {
                return Month.September;
            }
            else if (month == 10)
            {
                return Month.October;
            }
            else if (month == 11)
            {
                return Month.November;
            }
            else if (month == 12)
            {
                return Month.December;
            }
            else if (month < 1 || month > 12)
            {
                return null;
            }
            return 0;
        }

        public static Month? GetMonthWithSwitchStatement(int month)
        {
            switch (month)
            {
                case 1:
                    return Month.January;
                    break;
                case 2:
                    return Month.February;
                    break;
                case 3:
                    return Month.March;
                    break;
                case 4:
                    return Month.April;
                    break;
                case 5:
                    return Month.May;
                    break;
                case 6:
                    return Month.June;
                    break;
                case 7:
                    return Month.July;
                    break;
                case 8:
                    return Month.August;
                    break;
                case 9:
                    return Month.September;
                    break;
                case 10:
                    return Month.October;
                    break;
                case 11:
                    return Month.November;
                    break;
                case 12:
                    return Month.December;
                    break;
                default:
                    return null;
                    break;
            }
        }

        public static Month? GetMonthWithSwitchExpression(int month) => month switch
        {
            1 => Month.January,
            2 => Month.February,
            3 => Month.March,
            4 => Month.April,
            5 => Month.May,
            6 => Month.June,
            7 => Month.July,
            8 => Month.August,
            9 => Month.September,
            10 => Month.October,
            11 => Month.November,
            12 => Month.December,
            _ => null,
        };
    }
}
