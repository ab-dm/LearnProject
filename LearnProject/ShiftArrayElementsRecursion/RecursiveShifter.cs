using System;

namespace LearnProject.ShiftArrayElementsRecursion
{
    public static class RecursiveShifter
    {
        public static int[] Shift(int[] source, int[] iterations)
        {
            if (source is null)
            {
                throw new ArgumentNullException(nameof(source), "source array is null.");
            }

            if (iterations is null)
            {
                throw new ArgumentNullException(nameof(iterations), "iterations array is null.");
            }

            if (source.Length == 1)
            {
                return source;
            }

            static int[] LoopArray(int[] source, int[] iterations, int index = 0)
            {
                if (index < iterations.Length)
                {
                    if (index % 2 == 0 || index == 0)
                    {
                        int temp = iterations[index];
                        if (temp != 0)
                        {
                            ShiftLeft(source, temp);
                        }
                    }
                    else if (index % 2 != 0)
                    {
                        int temp = iterations[index];
                        if (temp >= 0 || temp != 0)
                        {
                            ShiftRight(source, temp);
                        }
                    }

                    LoopArray(source, iterations, index + 1);
                }

                return source;
            }

            static void ShiftRight(int[] source, int index)
            {
                if (index > 0)
                {
                    int firstIndex = source[0];
                    StepToRight(source, 0);
                    source[1] = firstIndex;
                    ShiftRight(source, index - 1);
                }
            }

            static void StepToRight(int[] source, int startIndex)
            {
                if (startIndex <= source.Length - 1)
                {
                    int temp = source[startIndex];
                    startIndex++;

                    StepToRight(source, startIndex);
                    if (startIndex <= source.Length - 1)
                    {
                        source[startIndex] = source[startIndex - 1];
                    }
                    else
                    {
                        source[source.Length - startIndex] = temp;
                    }
                }
            }

            static void ShiftLeft(int[] source, int index)
            {
                if (index > 0)
                {
                    int lastIndex = source[^1];
                    StepToLeft(source, source.Length);
                    source[^2] = lastIndex;
                    ShiftLeft(source, index - 1);
                }
            }

            static void StepToLeft(int[] source, int startIndex)
            {
                if (startIndex != 0)
                {
                    int temp = source[startIndex - 1];
                    startIndex--;

                    StepToLeft(source, startIndex);
                    if (startIndex != 0)
                    {
                        source[startIndex - 1] = source[startIndex];
                    }
                    else
                    {
                        source[source.Length - 1 - startIndex] = temp;
                    }
                }
            }

            return LoopArray(source, iterations);
        }
    }
}
