using System;

namespace LearnProject.ShiftArrayElementsRecursion
{
    public static class RecursiveEnumShifter
    {
        public static int[] Shift(int[] source, Direction[] directions)
        {
            if (source is null)
            {
                throw new ArgumentNullException(nameof(source), "source array is null.");
            }

            if (directions is null)
            {
                throw new ArgumentNullException(nameof(directions), "iterations array is null.");
            }

            static int[] ShiftRecursion(int[] source, Direction[] directions, int currentDirection = 0)
            {
                if (currentDirection != directions.Length)
                {
                    if (directions[currentDirection] == Direction.Left)
                    {
                        var temp = source[0];
                        Array.Copy(source, 1, source, 0, source.Length - 1);
                        source[^1] = temp;
                        ShiftRecursion(source, directions, currentDirection + 1);
                    }
                    else if (directions[currentDirection] == Direction.Right)
                    {
                        var temp = source[^1];
                        Array.Copy(source, 0, source, 1, source.Length - 1);
                        source[0] = temp;
                        ShiftRecursion(source, directions, currentDirection + 1);
                    }
                    else
                    {
                        throw new InvalidOperationException($"Incorrect {currentDirection} enum value.");
                    }
                }

                return source;
            }

            return ShiftRecursion(source, directions);
        }
    }
}
