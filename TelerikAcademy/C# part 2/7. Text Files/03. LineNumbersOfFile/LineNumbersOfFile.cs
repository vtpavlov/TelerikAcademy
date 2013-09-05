/*
 * Write a program that reads a text file and inserts line numbers in front of each of its lines. 
 * The result should be written to another text file.
*/


using System;
using System.IO;
using System.Text;

class LineNumbersOfFile
{
    static void Main()
    {
        try
        {
            //StreamReading and Writer for writing and reading
            StreamReader reader = new StreamReader("input.txt");
            StreamWriter writer = new StreamWriter("output.txt");
            //StringBuilder to construct the output data
            StringBuilder output = new StringBuilder();
            using (reader)
            {
                int lineNumber = 0;
                string line = reader.ReadLine();
                Console.WriteLine("Reading line 1...");
                while (line != null)
                {
                    lineNumber++;
                    //Appending to the StringBuilder
                    output.AppendFormat("Line {0}: {1}" + Environment.NewLine,
                    lineNumber, line);
                    line = reader.ReadLine();
                    Console.WriteLine("Reading line {0}...", lineNumber + 1);
                }
            }

            using (writer)
            {
                //Writing the data from the StringBuilder to the file
                writer.Write(output.ToString());
                Console.WriteLine("The result from the program was saved in output.txt!");
            }
        }
        catch (ArgumentException)
        {
            Console.WriteLine("File intput.txt does not exist or output.txt can't be created!");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File intput.txt does not exist or output.txt can't be created!");
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("The directory where one of the files or both should be does not exist!");
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

