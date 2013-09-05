/*
 * Write a program that removes from a text file all words listed in given another text file. 
 * Handle all possible exceptions in your methods.
*/


using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

class RemovingWordsListedInFile
{
    static void Main()
    {
        try
        {
            List<string> words = new List<string>();
            StreamReader file = new StreamReader("input.txt");
            StreamReader fileWithWords = new StreamReader("words.txt");

            using (fileWithWords)
            {
                string line = fileWithWords.ReadLine();
                while (line != null)
                {
                    string[] splittedLine = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (var word in splittedLine)
                    {
                        words.Add(word);
                    }
                    line = fileWithWords.ReadLine();
                }
            }

            string fileData;

            using (file)
            {
                fileData = file.ReadToEnd();
                foreach (string word in words)
                {
                    string regex = "\\b" + word + "\\b";
                    fileData = Regex.Replace(fileData, regex, m => "");
                }
            }
            StreamWriter writer = new StreamWriter("input.txt");
            using (writer)
            {
                writer.Write(fileData);                
            }
            Console.WriteLine("The program finished it's work successfuly!");
        }
        catch (ArgumentException)
        {
            Console.WriteLine("One or both of the files does not exist!");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("One or both of the files does not exist!");
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
            Console.WriteLine("The path to one or both of the files is too long!");
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


