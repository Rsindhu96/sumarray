using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumArray
{
    class Program
    {
        static void Main(String[] args)
        {
            int[,] matrix = {
            { 2, 4, 9 },
            { 3, 8, 4 },
            { 3, 4, 4 }
        };

            int[] rowSums = CalRowSums(matrix);
            int[] colSums = CalColSums(matrix);

            Console.WriteLine("Sum of rows:");
            PrintArray(rowSums);

            Console.WriteLine("Sum of columns:");
            PrintArray (colSums);
        }

        static int[] CalRowSums(int[,] matrix)
        {
            int numRows = matrix.GetLength(0);
            int numCols = matrix.GetLength(1);

            int[] rowSums = new int[numRows];

            for (int row = 0; row < numRows; row++)
            {
                int sum = 0;
                for (int col = 0; col < numCols; col++)
                {
                    sum += matrix[row, col];
                }
                rowSums[row] = sum;
            }

            return rowSums;
        }

        static int[] CalColSums(int[,] matrix)
        {
            int numRows = matrix.GetLength(0);
            int numCols = matrix.GetLength(1);

            int[] colSums = new int[numCols];

            for (int col = 0; col < numCols; col++)
            {
                int sum = 0;
                for (int row = 0; row < numRows; row++)
                {
                    sum += matrix[row, col];
                }
                colSums[col] = sum;
            }

            return colSums;
        }

        static void PrintArray(int[] array)
        {
            foreach (int value in array)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine();
        }
    }
}
