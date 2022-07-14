using System;
using System.Collections.Generic;

namespace LearnProject.SequencesTask
{
    public static class Sequences
    {
        public static string[] GetSubstrings(string numbers, int length)
        {
            if (numbers is null || string.IsNullOrEmpty(numbers))
            {
                throw new ArgumentException($"{numbers} is null or empty.");
            }

            if (length <= 0 || length > numbers.Length)
            {
                throw new ArgumentException($"{length} <= 0");
            }

            List<string> list = new List<string>();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (!char.IsDigit(numbers[i]))
                {
                    throw new ArgumentException($"{numbers[i]}");
                }

                string tmp = string.Empty;

                for (int j = i; j < numbers.Length; j++)
                {
                    tmp += numbers[j];

                    if (tmp == " ")
                    {
                        throw new ArgumentException($"{numbers[i]}");
                    }

                    if (tmp.Length == length)
                    {
                        list.Add(tmp);
                        break;
                    }
                }
            }

            return list.ToArray();
        }
    }
}
