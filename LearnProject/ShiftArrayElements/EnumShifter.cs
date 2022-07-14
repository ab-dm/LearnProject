using System;

namespace LearnProject.ShiftArrayElements
{
    public static class EnumShifter
    {
        public static int[] Shift(int[] source, Direction[] directions)
        {
            if (directions is null)
            {
                throw new ArgumentNullException(nameof(directions));
            }

            if (source is null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            foreach (var item in directions)
            {
                switch (item)
                {
                    case Direction.Left:
                        {
                            int temp = source[0];
                            for (int i = 0; i < source.Length - 1; i++)
                            {
                                source[i] = source[i + 1];
                            }

                            source[^1] = temp;
                            break;
                        }

                    case Direction.Right:
                        {
                            int temp = source[^1];
                            for (int i = source.Length - 1; i > 0; i--)
                            {
                                source[i] = source[i - 1];
                            }

                            source[0] = temp;
                            break;
                        }

                    default:
                        throw new InvalidOperationException($"Incorrect {source} enum value.");
                }
            }

            return source;
        }
    }
}
