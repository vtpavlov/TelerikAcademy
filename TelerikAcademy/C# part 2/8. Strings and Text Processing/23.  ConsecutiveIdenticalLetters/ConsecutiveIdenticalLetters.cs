/*
 * Write a program that reads a string from the console 
 * and replaces all series of consecutive identical letters with a single one.
*/

using System;
using System.Text;

class ConsecutiveIdenticalLetters
{
    static void Main()
    {
        Console.Write("Please enter a string: ");
        string text = Console.ReadLine();
        StringBuilder newText = new StringBuilder();
        char letter = text[0];
        newText.Append(letter);
        for (int i = 1; i < text.Length; i++)
        {
            if (text[i] != letter)
            {
                newText.Append(text[i]);
                letter = text[i];
            }
        }
        Console.WriteLine(newText.ToString());
    }
}