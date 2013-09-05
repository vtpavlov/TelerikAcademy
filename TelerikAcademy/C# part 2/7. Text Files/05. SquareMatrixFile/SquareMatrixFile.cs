/*
 * Write a program that reads a text file containing a square matrix 
 * of numbers and finds in the matrix an area of size 2 x 2 with a 
 * maximal sum of its elements. The first line in the input file 
 * contains the size of matrix N. Each of the next N lines contain N numbers separated by space. 
 * The output should be a single number in a separate text file. 
*/


using System;
using System.IO;

class SquareMatrixFile
{
    static void Main()
    {
        int[,] matrix;        
        int matrixSize;
        int bestSum = int.MinValue;
        int bestRow = 0;
        int bestCol = 0;

        try
        {
            StreamReader reader = new StreamReader("file.txt");

            using (reader)
            {
                matrixSize = int.Parse(reader.ReadLine());
                matrix = new int[matrixSize, matrixSize];
                int lineNumber = 0;
                string fileLine = reader.ReadLine();
                while (fileLine != null)
                {
                    string[] matrixLine = fileLine.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    for (int elementNumber = 0; elementNumber < matrixLine.Length; elementNumber++)
                    {
                        matrix[lineNumber, elementNumber] = int.Parse(matrixLine[elementNumber]);
                    }
                    fileLine = reader.ReadLine();
                    lineNumber++;
                }
                Console.WriteLine("The matrix was successfuly read from the file.");
            }

            //finding the square 2 x 2 that has maximal sum of its elements
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    int sum = matrix[row, col] + matrix[row, col + 1]
                        + matrix[row + 1, col] + matrix[row + 1, col + 1];
                    if (sum > bestSum)
                    {
                        bestRow = row;
                        bestCol = col;
                        bestSum = sum;
                    }
                }
            }
        }
        catch (ArgumentException)
        {
            Console.WriteLine("The file file.txt does not exist!");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("The file file.txt does not exist!");
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("The directory where the file file.txt should be does not exist!");
        }
        catch (IOException)
        {
            Console.WriteLine("IO Exception has accured!");
        }
        catch (OutOfMemoryException)
        {
            Console.WriteLine("Out of memory!");
        }

        try
        {
            StreamWriter writer = new StreamWriter("output.txt");

            using (writer)
            {
                writer.Write(bestSum);
                Console.WriteLine("The result from the program was successfuly saved to output.txt");
            }
        }
        catch (ArgumentException)
        {
            Console.WriteLine("Can't write to output.txt!");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Can't write to output.txt!");
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("The directory where the file output.txt should be does not exist!");
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("There is no permission for writing in the file output.txt!");
        }
        catch (System.Security.SecurityException)
        {
            Console.WriteLine("A security error has been detected!");
        }
        catch (ObjectDisposedException)
        {
            Console.WriteLine("It has been a problem to write into the file output.txt!");
        }
        catch (NotSupportedException)
        {
            Console.WriteLine("Compatibility error!");
        }
        catch (PathTooLongException)
        {
            Console.WriteLine("The path to output.txt is too long!");
        }
        catch (IOException)
        {
            Console.WriteLine("IO Exception has accured!");
        }
        catch (OutOfMemoryException)
        {
            Console.WriteLine("Out of memory!");
        }                      
    }
}