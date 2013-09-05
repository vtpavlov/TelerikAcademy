/*
 * Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), 
 * reads its contents and prints it on the console. 
 * Find in MSDN how to use System.IO.File.ReadAllText(…). 
 * Be sure to catch all possible exceptions and print user-friendly error messages.
*/


using System;

class FileReading
{
    static void Main()
    {
        string fileName;
        Console.Write("Please enter file name with it's full path: ");
        fileName = Console.ReadLine();
        try
        {
            string content = ReadFile(fileName);
            Console.WriteLine("File {0}: ", fileName);
            Console.WriteLine(content);
        }
        catch (System.IO.PathTooLongException)
        {
            Console.WriteLine("The path to the file is too long!");
        }
        catch (System.IO.DirectoryNotFoundException)
        {
            Console.WriteLine("The directory doesn't exist!");
        }
        catch (System.IO.FileNotFoundException)
        {
            Console.WriteLine("The file doesn't exist!");
        }
        catch (System.IO.IOException)
        {
            Console.WriteLine("There has been error with reading the file!");
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("You do not have permission to read this file!");
        }
        catch (NotSupportedException)
        {
            Console.WriteLine("The file is not supported!");
        }
        catch (System.Security.SecurityException)
        {
            Console.WriteLine("There has been error with security!");
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("You haven't entered file name and path!");
        }
        catch (ArgumentException)
        {
            Console.WriteLine("The file name or path is wrong!");
        }
        catch (OutOfMemoryException)
        {
            Console.WriteLine("Ran out of memory! The file might be too big.");
        }
    }

    private static string ReadFile(string fileName)
    {
        string fileContent = System.IO.File.ReadAllText(fileName);
        return fileContent;
    }
}