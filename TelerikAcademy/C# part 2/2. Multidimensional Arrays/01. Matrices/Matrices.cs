/*
 * Write a program that fills and prints a matrix of size (n, n) as shown below: (examples for n = 4)
 *
 *          A                            B                         C                         D   
 *   _______________             _______________            _______________           _______________
 *  | 1 | 5 | 9 | 13|           | 1 | 8 | 9 | 16|          | 7 | 11| 14| 16|         | 1 | 12| 11| 10|
 *  | 2 | 6 | 10| 14|           | 2 | 7 | 10| 15|          | 4 | 8 | 12| 15|         | 2 | 13| 16|  9|
 *  | 3 | 7 | 11| 15|           | 3 | 6 | 11| 14|          | 2 | 5 |  9| 13|         | 3 | 14| 15|  8|
 *  | 4 | 8 | 12| 16|           | 4 | 5 | 12| 13|          | 1 | 3 |  6| 10|         | 4 |  5|  6|  7|
 *   ---------------            ----------------           ---------------           ---------------
*/

using System;

class Matrices
{
    static void drawMatrixOfKindA()
    {
        Console.Write("Enter dimension of the matrix A: ");
        int N = int.Parse(Console.ReadLine());

        int[,] matrix = new int[N, N];
        int number = 1;  //variable that holds the number that we put inside the array cell

        //we fill the first col then the second but we start from the end and go to the top ((N - 1) - rows)
        for (int cols = 0; cols <= N - 1; cols++)
        {
            for (int rows = 0; rows <= N - 1; rows++)
            {
                if (cols % 2 == 0)
                {
                    matrix[rows, cols] = number;
                }
                else
                {
                    matrix[rows, cols] = number;
                }
                number++;
            }
        }

        //Printing the array matrix
        for (int i = 0; i <= N - 1; i++)
        {
            for (int j = 0; j <= N - 1; j++)
            {
                Console.Write("{0,4}", matrix[i, j]);
            }
            Console.WriteLine();
        }
        Console.WriteLine("\n\n");
    }

    static void drawMatrixOfKindB()
    {
        Console.Write("Enter dimension of the matrix B: ");
        int N = int.Parse(Console.ReadLine());

        int[,] matrix = new int[N, N];
        int number = 1;  //variable that holds the number that we put inside the array cell

        //we fill the first col then the second but we start from the end and go to the top ((N - 1) - rows)
        for (int cols = 0; cols <= N - 1; cols++)
        {           
            for (int rows = 0; rows <= N - 1; rows++)
            {
                if (cols % 2 == 0)
                {
                    matrix[rows, cols] = number;
                }
                else
                {
                    matrix[(N - 1) - rows, cols] = number;
                }
                number++;
            }            
        }

        //Printing the array matrix
        for (int i = 0; i <= N - 1; i++)
        {
            for (int j = 0; j <= N - 1; j++)
            {
                Console.Write("{0,4}", matrix[i, j]);
            }
            Console.WriteLine();
        }
        Console.WriteLine("\n\n");
    }

    static void drawMatrixOfKindC()
    {
        Console.Write("Enter dimension of the matrix C: ");
        int N = int.Parse(Console.ReadLine());

        int[,] matrix = new int[N, N];
        int number = 1;  //variable that holds the number that we put inside the array cell
        int colIncrement = 0; //variable that we add to it +1 every time in the first cycle

        //At the beggining we start with cell [N-1, 0], we are inside the second cycle
        //Then we save the number one in that cell, then we add to number + 1
        //We exit the second cycle because colIncrement is still 0, we add to colIncrement + 1
        //rows is now N-2 and we go inside the second cycle, the current cell is [N-2, 0]
        //we save in that cell the variable number which is now == 2, then we add to number and savingCurrentRows + 1
        //before that savingCurrentRows was equal to rows == N - 2, now it is again N - 1, we add to cols + 1
        //the current cell is [N-1, 1] and we assign to it the value of number which is 3 ... 

        for (int rows = N - 1; rows >= 0; rows--)
        {
            int savingCurrentRow = rows; //variable that saves the current row so we can increment it in the next for cycle

            for (int cols = 0; cols <= colIncrement; cols++)
            {
                matrix[savingCurrentRow, cols] = number;
                savingCurrentRow++;
                number++;
            }
            colIncrement++;
        }

        //so far we assigned values to the first half of the array, now we will fill and the rest of the array

        number = N * N;  //number gets the maximal value that there should be in a cell
        int colDecrement = N - 1; //variable that we decrement with 1 every time in the first cycle

        for (int rows = 0; rows <= N - 1; rows++)
        {
            int savingRows = rows;
            for (int j = N - 1; j >= colDecrement; j--)
            {
                matrix[savingRows, j] = number;
                savingRows--;
                number--;
            }
            colDecrement--;
        }

        //Printing the array matrix
        for (int i = 0; i <= N - 1; i++)
        {
            for (int j = 0; j <= N - 1; j++)
            {
                Console.Write("{0,4}", matrix[i, j]);
            }
            Console.WriteLine();
        }
        Console.WriteLine("\n\n");
    }

    static void drawMatrixOfKindD()
    {
        Console.Write("Enter dimension of the matrix D: ");
        int N = int.Parse(Console.ReadLine());

        int[,] matrix = new int[N, N];

        int counter = 1;
        int rows = 0;
        int cols = 0;
        int maxRows = N - 1;
        int maxCols = N - 1;

        do
        {
            //fill the first column
            for (int i = rows; i <= maxRows; i++)
            {
                matrix[i, cols] = counter;
                counter++;
            }
            cols++;
            //fill the last row
            for (int i = cols; i <= maxCols; i++)
            {
                matrix[maxRows, i] = counter;
                counter++;
            }
            maxRows--; //last row is filled so we decrement maxRows 
            //fill the last column
            for (int i = maxRows; i >= rows; i--)
            {
                matrix[i, maxCols] = counter;
                counter++;
            }
            maxCols--; //last column is filled so we decrement maxCols
            //fill the first row
            for (int i = maxCols; i >= cols; i--)
            {
                matrix[rows, i] = counter;
                counter++;
            }
            rows++;
        } while (counter <= N * N);

        //printing the matrix
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int k = 0; k < matrix.GetLength(1); k++)
            {
                Console.Write("{0,4}", matrix[i, k]);
            }
            Console.WriteLine();
        }
    }

    static void Main()
    {
        drawMatrixOfKindA();
        drawMatrixOfKindB();
        drawMatrixOfKindC();
        drawMatrixOfKindD();
    }
}