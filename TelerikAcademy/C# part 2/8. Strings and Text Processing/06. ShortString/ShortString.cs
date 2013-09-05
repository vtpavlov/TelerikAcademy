/*
 * Write a program that reads from the console a string of maximum 20 characters. 
 * If the length of the string is less than 20, the rest of the characters should 
 * be filled with '*'. Print the result string into the console.
*/


using System;

class ShortString
{
    private static string ConsoleInput()
    {
        Console.Write("Please enter a string of maximum 20 chars: ");
        string input = Console.ReadLine();
        if (input.Length > 20)
        {
            throw new ArgumentOutOfRangeException();
        }
        else
        {
            return input;
        }
    }

    static void Main(string[] args)
    {       
        try
        {
          string input = ConsoleInput();
          for (int i = 0; i < 20; i++)
          {
              if (i < input.Length)
              {
                  Console.Write(input[i]);
              }
              else
              {
                  Console.Write("*");
              }
          }
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("The string is longer then 20 symbols.");
        }
    
        Console.WriteLine();
    }
}