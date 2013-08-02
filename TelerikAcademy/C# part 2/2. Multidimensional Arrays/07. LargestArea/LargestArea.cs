/*
 * * Write a program that finds the largest area of equal 
 * neighbor elements in a rectangular matrix and prints its size. 
*/

using System;
using System.Collections.Generic;

class LargestArea
{
    //Class Position which we use to define a Node(element) in the matrix
    private class Position
    {
        private int Row { get; set; }
        private int Col { get; set; }

        public Position(int row, int col)
        {
            Row = row;
            Col = col;
        }

        //method used to compare two positions
        public static bool comparePositions(Position pos1, Position pos2)
        {
            if (pos1.Row == pos2.Row && pos1.Col == pos2.Col)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    //recursive function that goes trought all elements which are neighbours and are equal
    private static int DepthFirstSearch(int[,] matrix, int rootRow, int rootCol, List<Position> visitedPos, ref int count)
    {
        if (rootRow + 1 <= matrix.GetLength(0) - 1)  //check if we go outside the array
        {
            if (matrix[rootRow + 1, rootCol] == matrix[rootRow, rootCol]) //check if the bottom neighbour is equal
            {
                Position position = new Position(rootRow + 1, rootCol);
                bool theNodeIsVisited = false;
                foreach (var pos in visitedPos)
                {
                    if (Position.comparePositions(pos, position)) //check if the bottom neighbour is already visited before
                    {
                        theNodeIsVisited = true;
                    }
                }
                if (!theNodeIsVisited)
                {
                    count++;
                    visitedPos.Add(new Position(rootRow, rootCol)); //adding the current position to the list with visited Positions
                    DepthFirstSearch(matrix, rootRow + 1, rootCol, visitedPos, ref count); //recursive call
                }
            }
        }

        if (rootRow - 1 >= 0)
        {
            if (matrix[rootRow - 1, rootCol] == matrix[rootRow, rootCol])
            {
                Position position = new Position(rootRow - 1, rootCol);
                bool theNodeIsVisited = false;
                foreach (var pos in visitedPos)
                {
                    if (Position.comparePositions(pos, position))
                    {
                        theNodeIsVisited = true;
                    }
                }
                if (!theNodeIsVisited)
                {
                    count++;
                    visitedPos.Add(new Position(rootRow, rootCol));
                    DepthFirstSearch(matrix, rootRow - 1, rootCol, visitedPos, ref count);
                }
            }
        }

        if (rootCol + 1 <= matrix.GetLength(1) - 1)
        {
            if (matrix[rootRow, rootCol + 1] == matrix[rootRow, rootCol])
            {
                Position position = new Position(rootRow, rootCol + 1);
                bool theNodeIsVisited = false;
                foreach (var pos in visitedPos)
                {
                    if (Position.comparePositions(pos, position))
                    {
                        theNodeIsVisited = true;
                    }
                }
                if (!theNodeIsVisited)
                {
                    count++;
                    visitedPos.Add(new Position(rootRow, rootCol));
                    DepthFirstSearch(matrix, rootRow, rootCol + 1, visitedPos, ref count);
                }
            }
        }

        if (rootCol - 1 >= 0)
        {
            if (matrix[rootRow, rootCol - 1] == matrix[rootRow, rootCol])
            {
                Position position = new Position(rootRow, rootCol - 1);
                bool theNodeIsVisited = false;
                foreach (var pos in visitedPos)
                {
                    if (Position.comparePositions(pos, position))
                    {
                        theNodeIsVisited = true;
                    }
                }
                if (!theNodeIsVisited)
                {
                    count++;
                    visitedPos.Add(new Position(rootRow, rootCol));
                    DepthFirstSearch(matrix, rootRow, rootCol - 1, visitedPos, ref count);
                }
            }
        }
        return count;
    }

    static void Main()
    {
        //test matrices

        //int[,] matrix = 
        //{
        //    {1,3,2,2,2,4},
        //    {3,3,3,2,4,4},
        //    {4,3,1,2,3,3},
        //    {4,3,1,3,3,1},
        //    {4,3,3,3,1,1},
        //};

        //int[,] matrix = 
        //{
        //    {1,3},
        //    {3,3},
        //};

        //--------------- Comment this part and uncomment some of the test matrices if you don't want
        //to enter matrix manualy------------------------------------------------------------------
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
        //-----------------------------------------------------------------------------------------


        //printing the matrix
        Console.WriteLine("The matrix is: ");
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write(matrix[row, col] + " ");
            }
            Console.WriteLine();
        }

        int bestPath = int.MinValue;  //variable holding the longest path of same elements
        
        //The point of the list is to hold Nodes in the matrix which are already visited
        List<Position> entryPos = new List<Position>(); // entry list holding only 1 position [-1,-1] which doesn't exist
        entryPos.Add(new Position(-1, -1));
        
        //for cycles to visit all Nodes(elements)
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                int count = 1; //the current elements count

                DepthFirstSearch(matrix, row, col, entryPos, ref count);
                
                if (count >= bestPath)
                {
                    bestPath = count;
                }
            }            
        }

        Console.WriteLine("The count is: " + bestPath);
    }
}