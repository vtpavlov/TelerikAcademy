/*
 * Write a program that finds all prime numbers in the range [1...10 000 000]. 
 * Use the sieve of Eratosthenes algorithm (find it in Wikipedia).
*/

using System;

class PrimeNumbers
{
    static void Main()
    {
        bool[] array = new bool[10000000];
 
        int counter = 1;
        for (int i = 2; i < Math.Sqrt(array.Length); i++)
        {
            if (array[i] == false)
            {
                for (int j = i * i; j < array.Length; j = j + i)
                {
                    array[j] = true;

                }
            }
        }
        
        for (int i = 2; i < array.Length; i++)
        {
            if (array[i] == false)
            {
                counter++;
                Console.Write(i + " ");
            }
        }
        Console.WriteLine();
        Console.WriteLine("The number of prime numbers is: " + counter);
    }
}