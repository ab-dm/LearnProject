using System;
using System.Collections.Generic;

namespace LearnProject.SearchByPatternInText
{
    public static class Searcher
    {
        public static int[] SearchPatternString(this string text, string pattern, bool overlap)
        {
            if (text is null || pattern is null)
            {
                throw new ArgumentException("Argument is null");
            }

            var resultArray = new List<int>();
            int index = 0;
            int last = pattern.Length - 1;

            while (index < text.Length - last)
            {
                int petternIndex = 0;

                if (overlap)
                {
                    while (petternIndex <= last && text[index + petternIndex].ToString().ToLower(System.Globalization.CultureInfo.CurrentCulture) == pattern[petternIndex].ToString().ToLower(System.Globalization.CultureInfo.CurrentCulture))
                    {
                        petternIndex++;
                    }

                    if (petternIndex == pattern.Length)
                    {
                        resultArray.Add(index + 1);
                    }
                }
                else
                {
                    while (petternIndex <= last && text[index + petternIndex].ToString().ToLower(System.Globalization.CultureInfo.CurrentCulture) == pattern[petternIndex].ToString().ToLower(System.Globalization.CultureInfo.CurrentCulture))
                    {
                        petternIndex++;
                    }

                    if (petternIndex == pattern.Length)
                    {
                        resultArray.Add(index + 1);
                        index += petternIndex;
                        continue;
                    }
                }

                index++;
            }

            return resultArray.ToArray();
        }
    }
}
