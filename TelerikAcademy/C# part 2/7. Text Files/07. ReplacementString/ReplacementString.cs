/*
 * Write a program that replaces all occurrences of the substring "start" 
 * with the substring "finish" in a text file. 
 * Ensure it will work with large files (e.g. 100 MB).
*/


using System;
using System.IO;
using System.Text;

class ReplacementString
{
    static void Main()
    {
        try
        {
            StreamReader reader = new StreamReader("input.txt");
            StreamWriter writer = new StreamWriter("output.txt");
            using (reader)
            {
                using (writer)
                {
                    writer.Write(reader.ReadToEnd().Replace("start", "finish"));
                    Console.WriteLine("The program operations were successful and the output was saved in output.txt");
                }
            }
        }
        catch (ArgumentException)
        {
            Console.WriteLine("input.txt does not exist!");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("input.txt does not exist!");
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
            Console.WriteLine("It has been a problem to write into the file!");
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
