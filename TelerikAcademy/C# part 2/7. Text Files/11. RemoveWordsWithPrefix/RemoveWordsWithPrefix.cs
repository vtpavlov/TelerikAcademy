/*
 * Write a program that deletes from a text file all words that start with the prefix "test". 
 * Words contain only the symbols 0...9, a...z, A…Z, _.
*/


using System;
using System.IO;
using System.Text.RegularExpressions;

class RemoveWordsWithPrefix
{
    static void Main()
    {
        string fileData = "";
        string regex = "\\btest[0-9a-zA-Z_]*\\b";
        try
        {
            StreamReader reader = new StreamReader("input.txt");           
   
            using (reader)
            {
                fileData = reader.ReadToEnd();
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
            Console.WriteLine("The directory where the file input.txt should be does not exist!");
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
                writer.Write(Regex.Replace(fileData, regex, m => ""));
            }
            Console.WriteLine("The program finished it's work successfully!");
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
            Console.WriteLine("The directory where the file input.txt should be does not exist!");
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
