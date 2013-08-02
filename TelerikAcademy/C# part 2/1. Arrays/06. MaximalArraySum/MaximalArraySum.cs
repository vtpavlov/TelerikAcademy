/*
 * Write a program that reads two integer numbers N and K and an array of N elements from the console. 
 * Find in the array those K elements that have maximal sum.
*/

using System;

class MaximalArraySum
{
    static void Main()
    {
        Console.Write("Enter array's length: ");
        int n = int.Parse(Console.ReadLine());
       
        Console.Write("Enter the number K: ");
        int k = int.Parse(Console.ReadLine());        
        
        int[] array = new int[n];

        //Fill the array
        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter element {0}: ", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        //sorting the array
        Array.Sort(array);

        //printing the last K elements
        Console.Write("The {0} elements with maximal sum are: ", k);       
        for (int i = n - k; i < n; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }
}