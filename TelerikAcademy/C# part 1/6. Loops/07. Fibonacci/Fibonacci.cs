/*
 * Write a program that reads a number N and calculates 
 * the sum of the first N members of the sequence of 
 * Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …
 * Each member of the Fibonacci sequence (except the first two)
 * is a sum of the previous two members.
*/

using System;

class Fibonacci
{
    static void Main()
    {
        //getting number of Fibonacci members from console
        Console.Write("Please enter how many fibonacci members to print: ");
        int numberOfMembers = int.Parse(Console.ReadLine());

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
            for (int i = 3; i <= numberOfMembers; i++)
            {
                sum = number + nextNumber;
                Console.WriteLine(i + ". " + sum);
                number = nextNumber;
                nextNumber = sum;
            }
        }
    }
}
