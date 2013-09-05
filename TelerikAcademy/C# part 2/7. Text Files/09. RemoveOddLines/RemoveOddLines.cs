/*
 * Write a program that deletes from given text file all odd lines. The result should be in the same file.
*/


using System;
using System.IO;
using System.Text;

class RemoveOddLines
{
    static void Main()
    {
        StringBuilder outputText = new StringBuilder();
        try
        {
            StreamReader reader = new StreamReader("input.txt");

            using (reader)
            {
                int lineNumber = 0;
                string line = reader.ReadLine();
                while (line != null)
                {
                    lineNumber++;
                    if (lineNumber % 2 == 1)
                    {
                        outputText.Append(line + Environment.NewLine);
                    }
                    line = reader.ReadLine();
                }
            }
        }
        catch (ArgumentException)
        {
            Console.WriteLine("The file input.txt does not exist!");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("The file input.txt does not exist!");
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
            StreamWriter writer = new StreamWriter("input.txt");

            using (writer)
            {
                writer.Write(outputText.ToString());
            }

            Console.WriteLine("Successfuly removed all Odd lines from the file input.txt!");
        }
        catch (ArgumentException)
        {
            Console.WriteLine("Can't write to input.txt!");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Can't write to input.txt!");
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("The directory where the file output.txt should be does not exist!");
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("There is no permission for writing in the file input.txt!");
        }
        catch (System.Security.SecurityException)
        {
            Console.WriteLine("A security error has been detected!");
        }
        catch (ObjectDisposedException)
        {
            Console.WriteLine("It has been a problem to write into the file input.txt!");
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