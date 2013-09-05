/*
 * Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.
*/


using System;
using System.Collections.Generic;

class AlphabeticalOrder
{
    static void Main()
    {
        Console.Write("Please enter the words: ");
        string wordsString = Console.ReadLine();
        string[] wordsSplitted = wordsString.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
        List<string> words = new List<string>();
        foreach (var word in wordsSplitted)
        {
            words.Add(word);
        }
        words.Sort();
        Console.WriteLine("Alphabetical order: ");
        foreach (var word in words)
        {
            Console.WriteLine(word);
        }
        
    }
}