/*
 * Write a program that extracts from given HTML file its title (if available), and its body text without the HTML tags.
*/


using System;
using System.IO;
using System.Text.RegularExpressions;

class TitleExtraction
{
    static void Main()
    {
        try
        {
            //StreamReader to read the file file.html
            StreamReader reader = new StreamReader("file.html");
            using (reader)
            {
                string htmlText = reader.ReadToEnd();
                string titleRegex = "<title>(?<title>.*?)</title>";
                Console.WriteLine("Title: " + Regex.Match(htmlText, titleRegex, RegexOptions.IgnoreCase).Groups["title"]);
                string bodyRegex = "<body>(?<body>(.|\\s)*?)</body>";
                string bodyWithTags = Regex.Match(htmlText, bodyRegex, RegexOptions.IgnoreCase).Groups["body"].Value;                
                string tagRegex = "<.+?>|</.+?>";
                Console.WriteLine("Body: \n" + Regex.Replace(bodyWithTags, tagRegex, g => " "));
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