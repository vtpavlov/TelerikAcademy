/*
 * We are given a matrix of strings of size N x M. 
 * Sequences in the matrix we define as sets of several 
 * neighbor elements located on the same line, column or diagonal. 
 * Write a program that finds the longest sequence of equal strings in the matrix.
*/

using System;

class MatrixOfStrings
{
    //recursive function to find all diagonal neighbours
    static int findDiagonalNeighbours(string[,] matrix, int row, int col, int rows, int cols, ref int count)
    {
        if (row == rows - 1 || col == cols - 1)
        {
            return count;
        }
        else if (matrix[row + 1, col + 1] == matrix[row, col])
        {
            count++;
            findDiagonalNeighbours(matrix, row + 1, col + 1, rows, cols, ref count);
        }
        else if (matrix[row + 1, col + 1] != matrix[row, col])
        {
            return count;
        }
        return count;
    }

    //recursive function to find all Vertical neighbours
    static int findVerticalNeighbours(string[,] matrix, int row, int col, int rows, ref int count)
    {
        if (row == rows - 1)
        {
            return count;
        }
        else if (matrix[row + 1, col] == matrix[row, col])
        {
            count++;
            findVerticalNeighbours(matrix, row + 1, col, rows, ref count);
        }
        else if (matrix[row + 1, col] != matrix[row, col])
        {
            return count;
        }
        return count;
    }

    //recursive function to find all Horizontal neighbours
    static int findHorizontalNeighbours(string[,] matrix, int row, int col, int cols, ref int count)
    {
        if (col == cols - 1)
        {
            return count;
        }
        else if (matrix[row, col + 1] == matrix[row, col])
        {
            count++;
            findHorizontalNeighbours(matrix, row, col + 1, cols, ref count);
        }
        else if (matrix[row, col + 1] != matrix[row, col])
        {
            return count;
        }
        return count;
    }

    static void Main()
    {
        Console.Write("Please enter number of rows for the matrix: ");
        int rows = int.Parse(Console.ReadLine());

        Console.Write("Please enter number of columns for the matrix: ");
        int cols = int.Parse(Console.ReadLine());

        string[,] matrix = new string[rows, cols];

        //fill the matrix
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                Console.Write("Please enter element [{0}, {1}] of the matrix: ", row, col);
                matrix[row, col] = Console.ReadLine();
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

        int bestCount = int.MinValue;
        string element = "";

        //find the longest sequence of neighbours
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                int count = 1;
                findDiagonalNeighbours(matrix, row, col, rows, cols, ref count);
                if (count > bestCount)
                {
                    bestCount = count;
                    element = matrix[row, col];
                }

                count = 1;
                findVerticalNeighbours(matrix, row, col, rows, ref count);
                if (count > bestCount)
                {
                    bestCount = count;
                    element = matrix[row, col];
                }

                count = 1;
                findHorizontalNeighbours(matrix, row, col, cols, ref count);
                if (count > bestCount)
                {
                    bestCount = count;
                    element = matrix[row, col];
                }
            }
        }

        //print the result
        Console.Write("The best sequece is: ");
        for (int i = 0; i < bestCount; i++)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }
}
