namespace LearnProject.WorkingWithStrings
{
    public static class CopyingStrings
    {
        public static string CopyOneChar(string source, string destination)
        {
            char[] destinationArray = destination.ToCharArray();

            source.CopyTo(0, destinationArray, 4, source.Length);

            return new string(destinationArray);
        }

        public static string CopyThreeChars(string source, string destination)
        {
            char[] destinationArray = destination.ToCharArray();

            source.CopyTo(0, destinationArray, 0, source.Length);

            return new string(destinationArray);
        }

        public static string CopyFiveChars(string source, string destination)
        {
            char[] destinationArray = destination.ToCharArray();

            source.CopyTo(0, destinationArray, 4, source.Length);

            return new string(destinationArray);
        }

        public static string CopySixChars(string source, string destination)
        {
            char[] destinationArray = destination.ToCharArray();

            source.CopyTo(2, destinationArray, 5, source.Length - 4);

            return new string(destinationArray);
        }

        public static string GetProductionCode(string template, string regionCode, string locationCode, string dateCode, string factoryCode)
        {
            char[] templateArray = template.ToCharArray();

            regionCode.CopyTo(1, templateArray, 0, 1);
            locationCode.CopyTo(4, templateArray, 3, 2);
            dateCode.CopyTo(3, templateArray, 7, 3);
            factoryCode.CopyTo(2, templateArray, 12, 4);

            return new string(templateArray);
        }
    }
}
