/*
 * Write a program that finds the most frequent number in an array. 
 * Example: {4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3}  4 (5 times)
*/

using System;

class MostFrequentNumber
{
    static void Main()
    {
        //getting array's length
        Console.Write("Enter array's length:");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        
        //Fill the array
        for (int i = 0; i < n; i++)
        {
            Console.Write("Please enter element {0}: ", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        int countTemp = 0;
        int count = 1;
        int element = array[0];

        //algorithm to find the most frequent number
        for (int i = 0; i < n - 1; i++)
        {
            countTemp = 1;
            for (int j = i + 1; j < n; j++)
            {
                if (array[i] == array[j])
                {
                    countTemp++;
                }
            }
            if (countTemp >= count)
            {
                count = countTemp;
                element = array[i];
            }
        }

        //printing the result
        Console.WriteLine("The most frequent number in the array is {0} and it repeats {1} times.", element, count);
    }
}
