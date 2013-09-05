/*
 * Write a program that reads a string from the console and 
 * lists all different words in the string along with information 
 * how many times each word is found.
*/


using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class DifferentWords
{
    static void Main()
    {
        Console.Write("Please enter a string: ");
        string text = Console.ReadLine();
        string regex = "\\b\\w+\\b";        
        MatchCollection matches = Regex.Matches(text, regex, RegexOptions.IgnoreCase);
        List<string> words = new List<string>();
        foreach (var match in matches)
        {
            string newRegex = "\\b" + match.ToString() + "\\b";
            int count = Regex.Matches(text, newRegex, RegexOptions.IgnoreCase).Count;
            if (!words.Contains(match.ToString().ToLower() + " " + count))
            {
                words.Add(match.ToString().ToLower() + " " + count);
            }
           
        }

        foreach (var item in words)
        {
            Console.WriteLine(item);
        }
    }
}