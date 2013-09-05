/*
 * Write a program that reads a text file and prints on the console its odd lines.
*/


using System;
using System.IO;

class OddLinesInTextFile
{
    static void Main()
    {
        try
        {
            //StreamReader to read the file oddLines.txt
            StreamReader reader = new StreamReader("oddLines.txt");
            using (reader)
            {
                //Counter for the number of the current line
                int lineNumber = 0;
                //Reading the first line
                string line = reader.ReadLine();
                while (line != null)
                {
                    lineNumber++;
                    //check if the line is odd
                    if (lineNumber % 2 == 1)
                    {
                        //Printing the line to the console
                        Console.WriteLine("Line {0}: {1}",
                        lineNumber, line);
                    }
                    //Reding the next line
                    line = reader.ReadLine();
                }
            }
        }
        catch (ArgumentException)
        {
            Console.WriteLine("The file does not exist!");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("The file does not exist!");
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("The directory where the file should be does not exist!");
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
