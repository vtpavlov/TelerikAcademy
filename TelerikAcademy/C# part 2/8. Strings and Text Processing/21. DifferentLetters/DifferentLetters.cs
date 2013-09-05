/*
 * Write a program that reads a string from the console and prints all 
 * different letters in the string along with information how many times each letter is found. 
*/


using System;
using System.Text.RegularExpressions;

class DifferentLetters
{
    static void Main()
    {
        Console.Write("Please enter a string: ");
        string text = Console.ReadLine();
                
        for (int i = 'a'; i <= 'z'; i++)
        {
            int count = Regex.Matches(text, ((char)i).ToString(), RegexOptions.IgnoreCase).Count;
            if (count != 0)
            {
                Console.WriteLine("Letter: " + ((char)i).ToString() + " count: "
                + count);    
            }            
        }
    }
}