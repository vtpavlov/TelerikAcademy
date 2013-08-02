/*
 * Write a program that finds the maximal increasing sequence in an array. 
 * Example: {3, 2, 3, 4, 2, 2, 4}  {2, 3, 4}.
*/

using System;

class MinimalIncreasingSequence
{
    static void Main()
    {
        Console.Write("Please enter the length of the array: ");
        byte n = byte.Parse(Console.ReadLine());
        int[] array = new int[n];

        int counter = 0;
        int longestSequenceCount = 0;

        //Filling the array with values
        for (int i = 0; i < n; i++)
        {
            Console.Write("Please enter element {0}: ", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        //string variables to save the sequences
        string sequence = "";
        string longestSequence = array[0].ToString();

        for (int i = 0; i < n - 1; i++)
        {
            // check if the the next elements is greater 
            if (array[i] <= array[i + 1])
            {
                sequence += array[i] + " ";
                                
                counter++;
                if (counter > longestSequenceCount)
                {
                    longestSequenceCount = counter;
                    longestSequence = sequence + array[i + 1];
                }
            }
            else if (array[i] > array[i + 1])
            {
                counter = 0;
                sequence = "";
            }
        }
        Console.Write("The sequence is: {0} ", longestSequence);
    }
}