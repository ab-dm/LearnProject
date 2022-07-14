using System;
using System.Globalization;
using System.Linq;
using System.Text;

namespace LearnProject.LanguageGame
{
    public static class Translator
    {
        public static string TranslateToPigLatin(string phrase)
        {
            if (string.IsNullOrEmpty(phrase) || phrase == "    ")
            {
                throw new ArgumentException("Source string cannot be null or empty or whitespace.");
            }

            string temp = string.Empty;
            string punctuationMarks = ",.-! ";
            StringBuilder phraseResult = new StringBuilder();

            for (int i = 0; i < phrase.Length;)
            {
                if (punctuationMarks.Contains(phrase[i], StringComparison.Ordinal))
                {
                    phraseResult.Append(phrase[i]);
                    i++;
                }
                else
                {
                    int j = i;
                    while (j < phrase.Length)
                    {
                        if (punctuationMarks.Contains(phrase[j], StringComparison.Ordinal))
                        {
                            phraseResult.Append(SwapChar(temp));
                            i += temp.Length;
                            temp = string.Empty;
                            break;
                        }

                        temp += phrase[j].ToString();
                        j++;
                    }

                    if (temp.Length == phrase.Length)
                    {
                        phraseResult.Append(SwapChar(temp));
                        break;
                    }
                }
            }

            return phraseResult.ToString();
        }

        public static string SwapChar(string phrase)
        {
            if (string.IsNullOrEmpty(phrase) || phrase == "    ")
            {
                throw new ArgumentException("Source string cannot be null or empty or whitespace.");
            }

            if (phrase == "by")
            {
                return "byay";
            }

            string vowelSound = "aoeiuAOEIU";
            string endingWord = "ay";

            if (vowelSound.Contains(phrase.First(), StringComparison.Ordinal))
            {
                endingWord = "yay";
            }

            int i = 0;
            while (!vowelSound.Contains(phrase[i], StringComparison.Ordinal) && i < phrase.Length)
            {
                i++;
            }

            if (char.IsUpper(phrase.First()))
            {
                phrase = phrase[i..] + phrase[..i].ToLower(CultureInfo.CurrentCulture) + endingWord;
                phrase = phrase[0..1].ToUpper(CultureInfo.CurrentCulture) + phrase[1..^0];
                return phrase;
            }

            phrase = phrase[i..] + phrase[..i].ToLower(CultureInfo.CurrentCulture) + endingWord;

            return phrase;
        }
    }
}
