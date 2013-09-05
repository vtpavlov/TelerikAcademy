/*
 * Write a program that converts a string to a sequence of C# Unicode character literals. Use format strings. 
*/ 


using System;

class UnicodeConversion
{
    static void Main()
    {
        Console.Write("Please enter a string to be converted: ");
        string toBeConverted = Console.ReadLine();
        foreach (var symbol in toBeConverted)
        {            
            Console.Write("\\u" + ((int)symbol).ToString("X4"));
        }
        Console.WriteLine();
    }
}

