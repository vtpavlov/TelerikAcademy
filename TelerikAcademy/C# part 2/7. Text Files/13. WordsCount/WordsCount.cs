/*
 * Write a program that reads a list of words from a file words.txt 
 * and finds how many times each of the words is contained in another 
 * file test.txt. The result should be written in the file result.txt 
 * and the words should be sorted by the number of their occurrences 
 * in descending order. Handle all possible exceptions in your methods.
*/


using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

class WordsCount
{
    static void Main()
    {
        try
        {
            //Dictionary hold the word and number of how many times it's contained in test.txt
            Dictionary<string, int> words = new Dictionary<string, int>();
            //List holidng the words in words.txt
            List<string> wordsInFile = new List<string>();
            StreamReader file = new StreamReader("test.txt");
            StreamReader fileWithWords = new StreamReader("words.txt");

            //Reading words.txt and filling wordsInFile
            using (fileWithWords)
            {
                string line = fileWithWords.ReadLine();
                while (line != null)
                {
                    string[] splittedLine = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (var word in splittedLine)
                    {
                        wordsInFile.Add(word);
                    }
                    line = fileWithWords.ReadLine();
                }
            }

            string fileData;

            using (file)
            {
                //Reading the file test.txt
                fileData = file.ReadToEnd();
                foreach (var word in wordsInFile)
                {
                    //for each word in words.txt find the number of matches in test.txt 
                    //and Add in the dictionary the word + the count
                    string regex = "\\b" + word + "\\b";
                    int count = Regex.Matches(fileData, regex, RegexOptions.IgnoreCase).Count;
                    words.Add(word, count);
                }
            }

            //List holding the lines of the output file
            List<string> output = new List<string>();

            //The lines start with the number so we can sort the words by the number of occurrences        
            foreach (var item in words)
            {
                output.Add(item.Value + " : " + item.Key);
            }

            //Sorting and reversing the list
            output.Sort();
            output.Reverse();
            StreamWriter writer = new StreamWriter("result.txt");
            using (writer)
            {
                foreach (var item in output)
                {
                    writer.WriteLine(item);
                }
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
            Console.WriteLine("There is no permission for writing in the file result.txt!");
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
            Console.WriteLine("The path to result.txt is too long!");
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
