using System;
using System.Collections.Generic;
using System.Text;

namespace LearnProject.ParsingStrings
{
    public static class CharParser
    {
        public static bool TryParseChar(string str, out char result)
        {
            return char.TryParse(str, out result);
        }

        public static char ParseChar(string str)
        {
            try
            {
                return char.Parse(str);
            }
            catch (FormatException)
            {
                return ' ';
            }
        }
    }
}
