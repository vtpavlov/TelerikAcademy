/*
 * Modify the solution of the previous problem to replace only whole words (not substrings).
*/


using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

class ReplacementWords
{
    static void Main()
    {
        try
        {
            StreamReader reader = new StreamReader("input.txt");
            StreamWriter writer = new StreamWriter("output.txt");
            string regex = "\\bstart\\b";
            using (reader)
            {
                using (writer)
                {
                    string fileData = reader.ReadToEnd();
                    writer.Write(Regex.Replace(fileData, regex, m => "finish"));
                    Console.WriteLine("The word \"start\" was successfuly replaced with"
                        + " the word: finish! The output was saved in output.txt");
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