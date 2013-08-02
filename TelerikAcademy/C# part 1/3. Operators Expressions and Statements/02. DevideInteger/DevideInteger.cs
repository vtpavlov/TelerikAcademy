/*
 * Write a boolean expression that checks for given 
 * integer if it can be divided (without remainder) 
 * by 7 and 5 in the same time.
*/

using System;

class DevideInteger
{
    static void Main()
    {
        //Getting string input and converting it to integer
        Console.Write("Please enter a number to check if it can be devided by 7 and 5: ");
        int number = int.Parse(Console.ReadLine());

        //Boolean expression that checks if the number can be devided by 7 and 5 in the same time without remainder
        bool result = (number % 5 == 0) && (number % 7 == 0);

        //Printing the result
        Console.WriteLine("The number can be devided by 7 and 5 in the same time without remainder: " + result);
    }
}

