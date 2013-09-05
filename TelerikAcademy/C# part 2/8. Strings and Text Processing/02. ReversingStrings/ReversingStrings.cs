/*
 * Write a program that reads a string, reverses it and prints the result at the console.
*/


using System;
using System.Collections.Generic;
using System.Text;

class ReversingStrings
{
    static void Main()
    {
        try
        {
            //Getting the string from the console
            Console.Write("Please enter a string: ");
            string inputString = Console.ReadLine();
            List<char> inputStringInList = new List<char>();

            //Put the string in List
            foreach (char symbol in inputString)
            {
                inputStringInList.Add(symbol);
            }

            //Reversing the list
            inputStringInList.Reverse();
            StringBuilder reversedString = new StringBuilder();

            //Constructing the string with StringBuilder
            foreach (char symbol in inputStringInList)
            {
                reversedString.Append(symbol);
            }

            //Printing the result
            Console.WriteLine("The reversed string is: " + reversedString.ToString());
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("The string that you are trying to enter might be too long.");
        }
        catch (OutOfMemoryException)
        {
            Console.WriteLine("Out of memory!");
        }
    }
}
