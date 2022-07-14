using System;

namespace LearnProject.RelocationElementsTask
{
    public static class ArrayExtension
    {
        public static void MoveToTail(int[] source, int value)
        {
            if (source is null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            if (source.Length == 0)
            {
                throw new ArgumentException("Source array is empty!");
            }

            int tmp;
            int countValue = 0;

            foreach (var item in source)
            {
                if (value == item)
                {
                    countValue++;
                }
            }

            for (int i = 0; i < source.Length;)
            {
                if (value == source[i])
                {
                    tmp = source[i];

                    if (countValue > 0)
                    {
                        for (int j = i + 1; j < source.Length; j++)
                        {
                            source[j - 1] = source[j];
                        }

                        source[^1] = tmp;
                        countValue--;

                        if (countValue == 0)
                        {
                            break;
                        }
                    }
                }
                else
                {
                    i++;
                }
            }
        }
    }
}
