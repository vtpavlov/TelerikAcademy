/*
 * Write a program that generates and prints to the console 10 random values in the range [100, 200].
*/


using System;

class TenRandomValues
{
    private static Random randomGenerator = new Random();
    static void Main()
    {
        Console.Write("Ten random numbers: ");
        for (int i = 0; i < 10; i++)
        {
            Console.Write(randomGenerator.Next(100, 201) + " ");
        }
        Console.WriteLine();
    }
}