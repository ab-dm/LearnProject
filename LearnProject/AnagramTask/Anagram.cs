using System;
using System.Globalization;
using System.Text;

namespace LearnProject.AnagramTask
{
    public class Anagram
    {
        private readonly string sourceWord;

        public Anagram(string sourceWord)
        {
            if (sourceWord is null)
            {
                throw new ArgumentNullException(nameof(sourceWord));
            }

            if (sourceWord.Length == 0)
            {
                throw new ArgumentException("Source Word is null");
            }

            this.sourceWord = sourceWord;
        }

        public string[] FindAnagrams(string[] candidates)
        {
            if (candidates is null)
            {
                throw new ArgumentNullException(nameof(candidates));
            }

            if (candidates.Length == 0)
            {
                throw new ArgumentException("Array is null");
            }

            string[] result;
            char[] charsCandidates;
            char[] charSourceWord = this.sourceWord.ToLower(CultureInfo.CurrentCulture).ToCharArray();
            string sourceWordEquals = this.sourceWord.ToLower(CultureInfo.CurrentCulture);
            StringBuilder stringBuilder = new StringBuilder();
            char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

            Array.Sort(charSourceWord, alphabet);

            foreach (var item in candidates)
            {
#pragma warning disable CA1307 // Specify StringComparison
                if (item.Equals(sourceWordEquals))
#pragma warning restore CA1307 // Specify StringComparison
                {
                    return Array.Empty<string>();
                }

                charsCandidates = item.ToLower(CultureInfo.CurrentCulture).ToCharArray();
                Array.Sort(charsCandidates, alphabet);

                string stringSourceWord = new string(charSourceWord);
                string stringCandidates = new string(charsCandidates);

#pragma warning disable CA1307 // Specify StringComparison
                var compareNumber = string.Compare(stringSourceWord, stringCandidates);
#pragma warning restore CA1307 // Specify StringComparison

                if (compareNumber == 0)
                {
                    stringBuilder.Append(item + " ");
                }
            }

            if (stringBuilder.Length == 0)
            {
                return Array.Empty<string>();
            }

            string tmpResult = stringBuilder.ToString().Remove(stringBuilder.Length - 1, 1);

            result = tmpResult.Split(' ');
            return result;
        }
    }
}
