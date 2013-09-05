/*
 * Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".
*/


using System;
using System.Collections.Generic;
using System.Text;

class PalindromExtraction
{
    static void Main()
    {
        string text = "Those are palindromes: axa exe eehee helleh blaalb ABBA lamal and the rest are not.";
        List<char> letters = new List<char>();
        foreach (var letter in text)
        {
            letters.Add(letter);
        }
        letters.Reverse();
        StringBuilder reversedText = new StringBuilder();
        foreach (var letter in letters)
        {
            reversedText.Append(letter);
        }
        string[] normalTextSplitted = text.Split(new char[] { ' ', '.', ',', '!', '?', '\"', ':' },StringSplitOptions.RemoveEmptyEntries);
        string[] reversedTextSplitted = reversedText.ToString().Split(
            new char[] { ' ', '.', ',', '!', '?', '\"', ':' }, StringSplitOptions.RemoveEmptyEntries);
        foreach (var word in normalTextSplitted)
        {
            foreach (var reversed in reversedTextSplitted)
            {
                if (word == reversed)
                {
                    Console.WriteLine(reversed);
                }
            }
        }
    }
}