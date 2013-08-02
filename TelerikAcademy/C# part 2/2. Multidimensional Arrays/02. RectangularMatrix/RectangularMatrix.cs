/*
 * Write a program that reads a rectangular matrix of size N x M 
 * and finds in it the square 3 x 3 that has maximal sum of its elements.
*/

using System;

class RectangularMatrix
{
    static void Main()
    {
        Console.Write("Please enter number of rows for the matrix: ");
        int rows = int.Parse(Console.ReadLine());

        Console.Write("Please enter number of columns for the matrix: ");
        int cols = int.Parse(Console.ReadLine());

        int[,] matrix = new int[rows, cols];

        //fill the matrix
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                Console.Write("Please enter element [{0}, {1}] of the matrix: ", row, col);
                matrix[row, col] = int.Parse(Console.ReadLine());
            }
        }

        //printing the matrix
        Console.WriteLine("The matrix is: ");
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                Console.Write(matrix[row, col] + " ");
            }
            Console.WriteLine();
        }

        int bestSum = int.MinValue;
        int bestRow = 0;
        int bestCol = 0;

        //finding the square 3 x 3 that has maximal sum of its elements
        for (int row = 0; row < matrix.GetLength(0) - 2; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 2; col++)
            {
                int sum = matrix[row, col] + matrix[row, col + 1]
                    + matrix[row, col + 2] + matrix[row + 1, col]
                    + matrix[row + 1, col + 1] + matrix[row + 1, col + 2]
                    + matrix[row + 2, col] + matrix[row + 2, col + 1]
                    + matrix[row + 2, col + 2];
                if (sum > bestSum)
                {
                    bestRow = row;
                    bestCol = col;
                    bestSum = sum;
                }
            }
        }

        //printing the square 3 x 3 that has maximal sum of its elements
        Console.WriteLine("The square 3 x 3 that has maximal sum of its elements is: ");
        Console.WriteLine(matrix[bestRow, bestCol] + " " 
            + matrix[bestRow, bestCol + 1] + " "
            +matrix[bestRow, bestCol + 2]);
        Console.WriteLine(matrix[bestRow + 1, bestCol] + " "
            + matrix[bestRow + 1, bestCol + 1] + " "
            + matrix[bestRow + 1, bestCol + 2]);
        Console.WriteLine(matrix[bestRow + 2, bestCol] + " "
            + matrix[bestRow + 2, bestCol + 1] + " "
            + matrix[bestRow + 2, bestCol + 2]);
        //printing the bestSum variable
        Console.WriteLine("And the sum is: " + bestSum);
    }
}

