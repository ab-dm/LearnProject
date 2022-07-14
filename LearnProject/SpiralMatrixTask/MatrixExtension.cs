using System;

namespace LearnProject.SpiralMatrixTask
{
    public static class MatrixExtension
    {
        public static int[,] GetMatrix(int size)
        {
            if (size <= 0)
            {
                throw new ArgumentException($"Size of matrix '{size}' cannot be less or equal zero.");
            }

            int[,] matrix = new int[size, size];

            int count = 1;
            int startColumn = 0;
            int endColumn = size - 1;
            int startRow = 0;
            int endRow = size - 1;

            while (startColumn <= endColumn && startRow <= endRow)
            {
                for (int i = startColumn; i <= endColumn; i++)
                {
                    matrix[startRow, i] = count++;
                }

                for (int i = ++startRow; i <= endRow; i++)
                {
                    matrix[i, endColumn] = count++;
                }

                for (int i = --endColumn; i >= startColumn; i--)
                {
                    matrix[endRow, i] = count++;
                }

                for (int i = --endRow; i >= startRow; i--)
                {
                    matrix[i, startColumn] = count++;
                }

                startColumn++;
            }

            return matrix;
        }
    }

}
