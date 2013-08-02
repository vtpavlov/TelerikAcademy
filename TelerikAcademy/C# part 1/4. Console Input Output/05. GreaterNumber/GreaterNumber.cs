/*
 * Write a program that gets two numbers from 
 * the console and prints the greater of them. 
 * Don’t use if statements.
*/

using System;
using System.Globalization;
using System.Threading;

class GreaterNumber
{
    static void Main()
    {
        //changing the culture for the console
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        //Request for number one input
        Console.Write("Please enter number 1: ");
        double numberOne = double.Parse(Console.ReadLine());

        //Request for number two input
        Console.Write("Please enter number 2: ");
        double numberTwo = double.Parse(Console.ReadLine());

        //checking which number is bigger
        string result = numberOne >= numberTwo ? "The first number: " + numberOne + " is bigger then the second: " + numberTwo :
            "The second number: " + numberTwo + " is bigger then the first: " + numberOne;

        //printing the result
        Console.WriteLine(result);     
    }
}

