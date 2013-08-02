/*
 * Write a program that prints all the numbers from 1 to N.
*/

using System;

class NumbersToN
{
    static void Main()
    {
        //getting N from console
        Console.Write("Please enter a number: ");
        int n = int.Parse(Console.ReadLine());

        //printing the numbers from 1 to n
        for (int i = 1; i <= n; i++)
        {
            Console.Write(i + " ");
        }
    }
}

