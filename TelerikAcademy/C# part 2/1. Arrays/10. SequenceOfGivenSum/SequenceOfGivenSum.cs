/*
 * Write a program that finds in given array of integers a sequence of given sum S (if present). 
 * Example:	 {4, 3, 1, 4, 2, 5, 8}, S=11  {4, 2, 5}
*/

using System;

class SequenceOfGivenSum
{
    static void Main()
    {
        Console.Write("Enter array's length: ");
        int n = int.Parse(Console.ReadLine());
        
        int[] array = new int[n];
        
        //Fill the array
        for (int i = 0; i < n; i++)
        {
            Console.Write("Please enter element {0}: ", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        //asking for sum
        Console.Write("Please enter sum: ");
        int sum = int.Parse(Console.ReadLine());
        
        int start = 0;
        int end = 0;
        int tempSum = 0;
        
        //algorithm to find the sequence with sum equal to the sum
        for (int i = 0; i < n; i++)
        {
            tempSum = array[i];
            for (int j = i + 1; j < n; j++)
            {
                tempSum += array[j];
                if (tempSum == sum)
                {
                    start = i;
                    end = j;
                }
            }
        }

        //printing the result
        Console.Write("The sequence of elements with sum = {0} is: ", sum);
        for (int i = start; i <= end; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }
}
