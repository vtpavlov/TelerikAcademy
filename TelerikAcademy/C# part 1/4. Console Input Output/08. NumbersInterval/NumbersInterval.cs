/*
 * Write a program that reads an integer number n 
 * from the console and prints all the numbers in 
 * the interval [1..n], each on a single line.
*/

using System;

class NumbersInterval
{
    static void Main()
    {
        //Request for number n
        Console.Write("Please enter number n: ");
        uint n = uint.Parse(Console.ReadLine());

        //printing the numbers [1..n]
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(i);
        }
    }
}

