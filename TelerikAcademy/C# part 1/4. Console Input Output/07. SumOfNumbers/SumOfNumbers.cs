/*
 * Write a program that gets a number n and after
 * that gets more n numbers and calculates and prints their sum.
*/

using System;
using System.Globalization;
using System.Threading;

class SumOfNumbers
{
    static void Main()
    {
        //changing the culture for the console
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        //Request for number n
        Console.Write("Please enter number n: ");
        uint n = uint.Parse(Console.ReadLine());

        //variable to hold the sum
        double sum = 0;
         
        //for cycle to request na numbers and sum them
        for (int i = 1; i <= n; i++)
        {
            Console.Write("Please enter number {0}: ", i);
            sum += double.Parse(Console.ReadLine());
        }

        //printing the result
        Console.WriteLine("The sum of the n numbers is: " + sum);
    }
}

