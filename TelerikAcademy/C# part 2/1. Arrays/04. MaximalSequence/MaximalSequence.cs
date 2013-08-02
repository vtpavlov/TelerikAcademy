/*
 * Write a program that finds the maximal sequence of equal elements in an array.
 * Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1}  {2, 2, 2}.
*/

using System;

class MaximalSequence
{
    static void Main()
    {
        //getting the length of the array
        Console.Write("Plase enter the length of the array: ");
        byte n = byte.Parse(Console.ReadLine());
        int[] array = new int[n];
        
        //variable to count lengths of sequences
        int counter = 1;

        //variable to save the longest sequence
        int longestSequence = 1;
        
        //Fill the array
        for (int i = 0; i < n; i++)
        {
            Console.Write("Please enter element {0}: ", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        int element = array[0];

        for (int i = 0; i < n - 1; i++)
        {
            //checking if the the next elements is equal to the previous one
            if (array[i] == array[i + 1])
            {
                //counting how many elements are equal
                counter++;

                //saving the longest sequence if the new one is longer then the previous
                if (counter >= longestSequence) 
                {
                    longestSequence = counter;
                    element = array[i];
                }
            }
            else if (array[i] != array[i + 1])
            {
                counter = 1;
            }
        }
        Console.Write("The longest sequence is: ");
        for (int i = 0; i < longestSequence; i++)
        {
            Console.Write(element + " ");
        }
    }
}