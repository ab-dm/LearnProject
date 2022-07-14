using System;
using System.Collections.Generic;
using System.Text;

namespace LearnProject.ParsingStrings
{
    public static class BooleanParser
    {
        public static bool TryParseBoolean(string str, out bool result)
        {
            return bool.TryParse(str, out result);
        }

        public static bool ParseBoolean(string str)
        {
            try
            {
                return bool.Parse(str);
            }
            catch (FormatException)
            {
                return false;
            }
        }
    }
}
