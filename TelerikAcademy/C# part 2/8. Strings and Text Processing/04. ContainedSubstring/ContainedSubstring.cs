/*
 * Write a program that finds how many times a substring is contained in a given text (perform case insensitive search).
*/


using System;
using System.Text.RegularExpressions;

class ContainedSubstring
{
    static void Main()
    {
        Console.Write("Please enter a text: ");
        string text = Console.ReadLine();
        Console.Write("Please enter a substring to search for: ");
        string regex = Console.ReadLine();       
        int count = Regex.Matches(text, regex, RegexOptions.IgnoreCase).Count;
        Console.WriteLine("The count of substrings \"{0}\" in the text is: " + count, regex);
    }
}