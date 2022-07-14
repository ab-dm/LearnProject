using System;

namespace LearnProject.WorkingWithStrings
{
    public static class SplittingStrings
    {
        public static string[] SplitCommaSeparatedString(string str)
        {
            return str.Split(',');
        }

        public static string[] SplitColonSeparatedString(string str)
        {
            return str.Split(':');
        }

        public static string[] SplitCommaSeparatedStringMaxTwoElements(string str)
        {
            return str.Split(',', 2);
        }

        public static string[] SplitColonSeparatedStringMaxThreeElements(string str)
        {
            return str.Split(':', 3);
        }

        public static string[] SplitHyphenSeparatedStringMaxThreeElementsRemoveEmptyStrings(string str)
        {
            return str.Split('-', 3, StringSplitOptions.RemoveEmptyEntries);
        }

        public static string[] SplitColonAndCommaSeparatedStringMaxFourElementsRemoveEmptyStrings(string str)
        {
            char[] separated = { ':', ',' };
            return str.Split(separated, 4, StringSplitOptions.RemoveEmptyEntries);
        }

        public static string[] GetOnlyWords(string str)
        {
            char[] separated = { ' ', '.', ',', ':', '-', '!', '\t' };
            return str.Split(separated, StringSplitOptions.RemoveEmptyEntries);
        }

        public static string[] GetDataFromCsvLine(string str)
        {
            char[] separated = { ' ', ',' };
            return str.Split(separated, StringSplitOptions.RemoveEmptyEntries);
        }
    }
}
