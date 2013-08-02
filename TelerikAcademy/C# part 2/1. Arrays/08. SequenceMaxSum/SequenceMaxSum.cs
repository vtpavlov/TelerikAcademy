/*
 * Write a program that finds the sequence of maximal sum in given array. Example:
 * {2, 3, -6, -1, 2, -1, 6, 4, -8, 8}  {2, -1, 6, 4}
 * Can you do it with only one loop (with single scan through the elements of the array)?
*/

using System;

class SequenceMaxSum
{
    static void Main()
    {
        Console.Write("Enter array's length: ");
        int n = int.Parse(Console.ReadLine());

        int[] array = new int[n];
       
        //Fill the array
        for (int i = 0; i < n; i++)
        {
            Console.Write("Please enter element {0} of the array: ", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        // using Kadane's algorithm
        int maxSoFar = array[0];
        int maxEndingHere = array[0];
        int begin = 0;
        int beginTemp = 0;
        int end = 0;
  
        for (int i = 1; i < n; i++)
        {
            maxEndingHere += array[i];
            if (array[i] > maxEndingHere)
            {
                maxEndingHere = array[i];
                beginTemp = i;
            }
            if (maxEndingHere > maxSoFar)
            {
                maxSoFar = maxEndingHere;
                begin = beginTemp;
                end = i;
            }
        }

        //printing the sub array that we searched for
        for (int i = begin; i <= end; i++)
        {
            Console.Write(array[i] + " ");
        }
    }
}