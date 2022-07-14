using System;

namespace LearnProject.VowelCountTask
{
    public class StringHelper
    {
        public static int GetCountOfVowel(string source)
        {
            if (source is null || source.Length == 0)
            {
                throw new ArgumentException("String cannot be null or empty.");
            }

            char[] chars = { 'a', 'e', 'i', 'o', 'u' };

            int countOfVowel = 0;

            foreach (char itemSource in source)
            {
                foreach (var itemChars in chars)
                {
                    if (itemChars == itemSource)
                    {
                        countOfVowel++;
                    }
                }
            }

            return countOfVowel;
        }
    }
}
