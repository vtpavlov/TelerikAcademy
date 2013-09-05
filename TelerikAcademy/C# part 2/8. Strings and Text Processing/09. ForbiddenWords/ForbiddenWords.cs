/*
 * We are given a string containing a list of forbidden words and a text containing some of these words. 
 * Write a program that replaces the forbidden words with asterisks.
*/

using System;
using System.Text.RegularExpressions;

class ForbiddenWords
{
    static void Main()
    {
        string text = "Microsoft announced its next generation PHP compiler today." 
            + " It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
        string words = "PHP,CLR,Microsoft";
        string[] eachWord = words.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

        foreach (var word in eachWord)
        {
            text = Regex.Replace(text, word, g => new string('*', word.Length));
        }

        Console.WriteLine(text);
    }
}