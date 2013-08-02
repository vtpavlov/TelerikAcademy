/*
 * Write a program that safely compares floating-point 
 * numbers with precision of 0.000001. Examples:
 * (5.3 ; 6.01) -> false;  (5.000 000 01 ; 5.000 000 03) -> true
*/

using System;

class FloatComparison
{
    static void Main()
    {
        //Asking for input of the first number
        Console.Write("Please enter the first number that u want to compare: ");
        double firstNumber = double.Parse(Console.ReadLine());
        //rounding the first number
        firstNumber = Math.Round(firstNumber, 6);
        //Asking for input of the second number
        Console.Write("Now enter the second number: ");
        double secondNumber = double.Parse(Console.ReadLine());
        //rounding the second number
        secondNumber = Math.Round(secondNumber, 6);
        //Comparing the two numbers
        bool equalTo = (firstNumber == secondNumber);
        //Printing the result
        Console.WriteLine("The numbers are equal: {0}", equalTo);
    }
}
