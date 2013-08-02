/*
 * Write a program that prints all the numbers from 1 to N, 
 * that are not divisible by 3 and 7 at the same time.
*/

using System;

class NumbersNotDivisible
{
    static void Main()
    {
        //getting N from console
        Console.Write("Please enter a number: ");
        int n = int.Parse(Console.ReadLine());

        //printing the numbers from 1 to n not divisible by 3 and 7 at the same time
        for (int i = 1; i <= n; i++)
        {
            if (!(i % 3 == 0 && i % 7 == 0))
            {
                Console.Write(i + " ");
            }
        }
    }
}

