/*
 * Write a program that reads a text file containing a list of strings, 
 * sorts them and saves them to another text file. 
*/

using System;
using System.Collections.Generic;
using System.IO;

class SortingStringsInFile
{
    static void Main()
    {
        try
        {
            StreamReader reader = new StreamReader("input.txt");
            List<string> outputFileData = new List<string>();
            using (reader)
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    string[] words = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (var word in words)
                    {
                        outputFileData.Add(word);
                    }
                    line = reader.ReadLine();
                }
            }
            outputFileData.Sort();
            Console.WriteLine("input.txt was read successfuly and sorted!");
            StreamWriter writer = new StreamWriter("output.txt");
            using (writer)
            {
                foreach (var item in outputFileData)
                {
                    writer.WriteLine(item);                    
                }
                Console.WriteLine("The sorted strings were successfuly saved to output.txt!");
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