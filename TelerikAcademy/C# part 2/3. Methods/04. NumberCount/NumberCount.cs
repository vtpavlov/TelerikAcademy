/*
 * Write a method that counts how many times given number appears in given array. 
 * Write a test program to check if the method is working correctly.
*/


using System;

class NumberCount
{
    static int NumberCountInArray(int number, int[] array)
    {
        //variable to keep the count of the number appearances
        int count = 0;

        //cycle to find the count
        for (int i = 0; i < array.Length; i++)
        {
            if (number == array[i])
            {
                count++;
            }
        }

        //returning the count
        return count;        
    }

    static void Main()
    {
        int[] array = { 1, 1, 1, 2, 34, 4, 3, 2, 4, 5, 2, 3, 5, 6, 7, 7, 8, 5, 4, 2, 4, 6, 7, 5, 23, 3 };
        Console.WriteLine("Count of the number 2 in the array:" 
            + " \n1, 1, 1, 2, 34, 4, 3, 2, 4, 5, 2, 3, 5, 6, 7, 7, 8, 5, 4, 2, 4, 6, 7, 5, 23, 3\nis: " 
            + NumberCountInArray(2, array));
    }
}
