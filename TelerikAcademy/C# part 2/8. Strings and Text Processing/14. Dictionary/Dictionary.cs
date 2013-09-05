/*
 * A dictionary is stored as a sequence of text lines containing words and their explanations. 
 * Write a program that enters a word and translates it by using the dictionary.
*/

using System;
using System.Text.RegularExpressions;

class Dictionary
{
    static void Main()
    {
        string dictionary = ".NET - platform for applications from Microsoft\n" +
            "CLR - managed execution environment for .NET\n" +
            "namespace - hierarchical organization of classes\n";
        Console.Write("Please enter a word: ");
        string regex = Console.ReadLine() + "\\s-\\s(?<meaning>.*)";
        Console.WriteLine(Regex.Match(dictionary,regex,RegexOptions.IgnoreCase).Groups["meaning"]);

    }
}
