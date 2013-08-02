/*
 * Write an expression that checks if given integer is odd or even.
*/

using System;

class OddOrEven
{
    static void Main()
    {
        //Getting string input and converting it to integer
        Console.Write("Please enter a number to check if it's even or odd: ");
        int number = int.Parse(Console.ReadLine());

        //Expression that checks if the number is odd
        string result = number % 2 == 0 ? "The number is even!" : "The number is odd!";
        
        //Printing the result
        Console.WriteLine(result);
    }
}