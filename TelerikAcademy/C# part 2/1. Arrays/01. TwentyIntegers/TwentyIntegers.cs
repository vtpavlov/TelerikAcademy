/*
 * Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5.
 * Print the obtained array on the console.
*/

using System;

class TwentyIntegers
{
    static void Main()
    {
        //allocating array
        int[] twentyIntegers = new int[20];
        for (int i = 0; i < twentyIntegers.Length; i++)
        {
            //giving value to the I-th element
            twentyIntegers[i] = i * 5;
            Console.Write(twentyIntegers[i] + " ");
        }
    }
}
