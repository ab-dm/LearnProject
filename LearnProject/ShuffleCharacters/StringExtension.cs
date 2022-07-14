using System;

namespace LearnProject.ShuffleCharacters
{
    public static class StringExtension
    {
        public static string ShuffleChars(string source, int count)
        {
            if (string.IsNullOrEmpty(source))
            {
                throw new ArgumentException("source is null or empty");
            }

            if (string.IsNullOrWhiteSpace(source))
            {
                throw new ArgumentException("source is white space");
            }

            if (count < 0)
            {
                throw new ArgumentException("count < 0");
            }

            bool SequenceEqual(char[] a, char[] b)
            {
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] != b[i])
                    {
                        return false;
                    }
                }

                return true;
            }

            if (string.IsNullOrEmpty(source) || count < 1)
            {
                return source;
            }

            char[] result = source.ToCharArray();
            char[] array = new char[source.Length];
            char[] start = new char[source.Length];
            Array.Copy(result, start, result.Length);
            var t = 0;
            int middle = (source.Length / 2) + (source.Length % 2);
            for (int k = 0; k < count; k++)
            {
                (array, result) = (result, array);

                for (int i = 0; i < middle; i++)
                {
                    result[i] = array[i * 2];
                }

                for (int i = middle, ii = 1; i < source.Length; i++, ii += 2)
                {
                    result[i] = array[ii];
                }

                t++;
                if (SequenceEqual(result, start))
                {
                    while (count > k + t)
                    {
                        count -= t;
                    }
                }
            }

            return new string(result);
        }
    }
}
