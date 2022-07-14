using System;
using System.Collections.Generic;
using System.Text;

namespace LearnProject.SearchingInStrings
{
    public static class LastIndexOfAny
    {
        public static int GetLastIndexOfAny(string str, char[] anyOf)
        {
            return str.LastIndexOfAny(anyOf);
        }

        public static int GetLastIndexOfAny(string str, char[] anyOf, int startIndex)
        {
            return str.LastIndexOfAny(anyOf, startIndex);
        }

        public static int GetLastIndexOfAny(string str, char[] anyOf, int startIndex, int count)
        {
            return str.LastIndexOfAny(anyOf, startIndex, count);
        }
    }
}
