/*
 * Write a program that reads from the console 
 * a sequence of N integer numbers and returns 
 * the minimal and maximal of them.
*/

using System;

class SequenceOfIntegers
{
    static void Main()
    {
        //getting N from console
        Console.Write("Please enter a number of numbers: ");
        int n = int.Parse(Console.ReadLine());
        int minimal = int.MaxValue;
        int maximal = int.MinValue;

        //loop to get the numbers and find the minimal and maximal of them
        for (int i = 1; i <= n; i++)
        {
            Console.Write("Please enter number {0}: ", i);
            int number = int.Parse(Console.ReadLine());
            if (number < minimal)
            {
                minimal = number;
            }
            if (number > maximal)
            {
                maximal = number;
            }
        }

        //printing the minimal and maximal number
        Console.WriteLine("The minimal number is: {0} and the maximal {1}.", minimal, maximal);
    }
}
