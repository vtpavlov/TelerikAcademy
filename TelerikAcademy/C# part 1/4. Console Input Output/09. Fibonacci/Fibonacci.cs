/*
 * Write a program to print the first 
 * 100 members of the sequence of Fibonacci: 
 * 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …
*/

using System;

class Fibonacci
{
    static void Main()
    {
        //double because with long and ulong there is overflow exception
        double number = 0;
        double nextNumber = 1;
        double sum;

        //printing the first 2 members
        Console.WriteLine("1. " + number);
        Console.WriteLine("2. " + nextNumber);
        
        //checking for overflow exception
        checked
        {
            //printing the rest of the numbers
            for (int i = 3; i <= 100; i++)
            {
                sum = number + nextNumber;
                Console.WriteLine(i + ". " + sum);
                number = nextNumber;
                nextNumber = sum;
            }
        }
    }
}

