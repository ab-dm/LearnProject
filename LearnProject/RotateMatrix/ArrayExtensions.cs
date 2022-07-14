using System;

namespace LearnProject.RotateMatrix
{
    public static class ArrayExtensions
    {
        public static void Rotate90DegreesClockwise(this int[,] matrix)
        {
            if (matrix is null)
            {
                throw new ArgumentNullException(nameof(matrix));
            }

            int length = matrix.GetLength(0);

            for (int i = 0; i < length / 2; i++)
            {
                for (int j = i; j < length - 1 - i; j++)
                {
                    int tmp = matrix[i, j];
                    matrix[i, j] = matrix[length - j - 1, i];
                    matrix[length - j - 1, i] = matrix[length - i - 1, length - j - 1];
                    matrix[length - i - 1, length - j - 1] = matrix[j, length - i - 1];
                    matrix[j, length - i - 1] = tmp;
                }
            }
        }

        public static void Rotate90DegreesCounterClockwise(this int[,] matrix)
        {
            if (matrix is null)
            {
                throw new ArgumentNullException(nameof(matrix));
            }

            int length = matrix.GetLength(0);

            for (int i = 0; i < length / 2; i++)
            {
                for (int j = i; j < length - 1 - i; j++)
                {
                    int tmp = matrix[i, j];
                    matrix[i, j] = matrix[j, length - 1 - i];
                    matrix[j, length - 1 - i] = matrix[length - 1 - i, length - 1 - j];
                    matrix[length - 1 - i, length - 1 - j] = matrix[length - 1 - j, i];
                    matrix[length - 1 - j, i] = tmp;
                }
            }
        }

        public static void Rotate180DegreesClockwise(this int[,] matrix)
        {
            if (matrix is null)
            {
                throw new ArgumentNullException(nameof(matrix));
            }

            int length = matrix.GetLength(0);

            for (int i = 0; i < length / 2; i++)
            {
                for (int j = i; j < length - 1 - i; j++)
                {
                    int tmp = matrix[i, j];
                    matrix[i, j] = matrix[length - j - 1, i];
                    matrix[length - j - 1, i] = matrix[length - i - 1, length - j - 1];
                    matrix[length - i - 1, length - j - 1] = matrix[j, length - i - 1];
                    matrix[j, length - i - 1] = tmp;
                    int tmp2 = matrix[i, j];
                    matrix[i, j] = matrix[length - j - 1, i];
                    matrix[length - j - 1, i] = matrix[length - i - 1, length - j - 1];
                    matrix[length - i - 1, length - j - 1] = matrix[j, length - i - 1];
                    matrix[j, length - i - 1] = tmp2;
                }
            }
        }

        public static void Rotate180DegreesCounterClockwise(this int[,] matrix)
        {
            if (matrix is null)
            {
                throw new ArgumentNullException(nameof(matrix));
            }

            int length = matrix.GetLength(0);

            for (int i = 0; i < length / 2; i++)
            {
                for (int j = i; j < length - 1 - i; j++)
                {
                    int tmp = matrix[i, j];
                    matrix[i, j] = matrix[j, length - 1 - i];
                    matrix[j, length - 1 - i] = matrix[length - 1 - i, length - 1 - j];
                    matrix[length - 1 - i, length - 1 - j] = matrix[length - 1 - j, i];
                    matrix[length - 1 - j, i] = tmp;
                    int tmp2 = matrix[i, j];
                    matrix[i, j] = matrix[j, length - 1 - i];
                    matrix[j, length - 1 - i] = matrix[length - 1 - i, length - 1 - j];
                    matrix[length - 1 - i, length - 1 - j] = matrix[length - 1 - j, i];
                    matrix[length - 1 - j, i] = tmp2;
                }
            }
        }

        public static void Rotate270DegreesClockwise(this int[,] matrix)
        {
            if (matrix is null)
            {
                throw new ArgumentNullException(nameof(matrix));
            }

            int length = matrix.GetLength(0);

            for (int i = 0; i < length / 2; i++)
            {
                for (int j = i; j < length - 1 - i; j++)
                {
                    int tmp = matrix[i, j];
                    matrix[i, j] = matrix[length - j - 1, i];
                    matrix[length - j - 1, i] = matrix[length - i - 1, length - j - 1];
                    matrix[length - i - 1, length - j - 1] = matrix[j, length - i - 1];
                    matrix[j, length - i - 1] = tmp;
                    int tmp2 = matrix[i, j];
                    matrix[i, j] = matrix[length - j - 1, i];
                    matrix[length - j - 1, i] = matrix[length - i - 1, length - j - 1];
                    matrix[length - i - 1, length - j - 1] = matrix[j, length - i - 1];
                    matrix[j, length - i - 1] = tmp2;
                    int tmp3 = matrix[i, j];
                    matrix[i, j] = matrix[length - j - 1, i];
                    matrix[length - j - 1, i] = matrix[length - i - 1, length - j - 1];
                    matrix[length - i - 1, length - j - 1] = matrix[j, length - i - 1];
                    matrix[j, length - i - 1] = tmp3;
                }
            }
        }

        public static void Rotate270DegreesCounterClockwise(this int[,] matrix)
        {
            if (matrix is null)
            {
                throw new ArgumentNullException(nameof(matrix));
            }

            int length = matrix.GetLength(0);

            for (int i = 0; i < length / 2; i++)
            {
                for (int j = i; j < length - 1 - i; j++)
                {
                    int tmp = matrix[i, j];
                    matrix[i, j] = matrix[j, length - 1 - i];
                    matrix[j, length - 1 - i] = matrix[length - 1 - i, length - 1 - j];
                    matrix[length - 1 - i, length - 1 - j] = matrix[length - 1 - j, i];
                    matrix[length - 1 - j, i] = tmp;
                    int tmp2 = matrix[i, j];
                    matrix[i, j] = matrix[j, length - 1 - i];
                    matrix[j, length - 1 - i] = matrix[length - 1 - i, length - 1 - j];
                    matrix[length - 1 - i, length - 1 - j] = matrix[length - 1 - j, i];
                    matrix[length - 1 - j, i] = tmp2;
                    int tmp3 = matrix[i, j];
                    matrix[i, j] = matrix[j, length - 1 - i];
                    matrix[j, length - 1 - i] = matrix[length - 1 - i, length - 1 - j];
                    matrix[length - 1 - i, length - 1 - j] = matrix[length - 1 - j, i];
                    matrix[length - 1 - j, i] = tmp3;
                }
            }
        }

        public static void Rotate360DegreesClockwise(this int[,] matrix)
        {
            if (matrix is null)
            {
                throw new ArgumentNullException(nameof(matrix));
            }
        }

        public static void Rotate360DegreesCounterClockwise(this int[,] matrix)
        {
            if (matrix is null)
            {
                throw new ArgumentNullException(nameof(matrix));
            }
        }
    }

}
