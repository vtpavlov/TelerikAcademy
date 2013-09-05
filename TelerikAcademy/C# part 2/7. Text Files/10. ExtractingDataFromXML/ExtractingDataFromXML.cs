/*
 * Write a program that extracts from given XML file all the text without the tags. 
*/


using System;
using System.IO;
using System.Text.RegularExpressions;

class ExtractingDataFromXML
{
    static void Main()
    {
        try
        {
            StreamReader reader = new StreamReader("input.xml");
            string regex = "<[^<>]+>";
            using (reader)
            {
                string fileData = reader.ReadToEnd();
                string[] dataInsideTags = Regex.Split(fileData, regex, RegexOptions.IgnorePatternWhitespace);
                Console.WriteLine("The data inside the tags is: ");
                foreach (string element in dataInsideTags)
                {
                    if (element != null && element != "")
                    {
                        Console.WriteLine(element);
                    }
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