using System;

namespace LearnProject.ShiftArrayElements
{
    public static class Shifter
    {
        public static int[] Shift(int[] source, int[] iterations)
        {
            if (iterations is null)
            {
                throw new ArgumentNullException(nameof(iterations));
            }

            if (source is null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            for (int i = 0; i < iterations.Length; i++)
            {
                int count = iterations[i];

                if (i % 2 == 0 || i == 0)
                {
                    while (count > 0)
                    {
                        var temp = source[0];
                        Array.Copy(source, 1, source, 0, source.Length - 1);
                        source[^1] = temp;
                        count--;
                    }
                }
                else if (i % 2 != 0)
                {
                    while (count > 0)
                    {
                        var temp = source[^1];
                        Array.Copy(source, 0, source, 1, source.Length - 1);
                        source[0] = temp;
                        count--;
                    }
                }
            }

            return source;
        }
    }
}
