/*
 * You are given an array of strings. 
 * Write a method that sorts the array by the 
 * length of its elements (the number of characters composing them).
*/

using System;

class SortingStringsByLength
{
    static void Main()
    {
        //console input
        Console.Write("Please enter the length of the array: ");
        int arrayLength = int.Parse(Console.ReadLine());

        string[] array = new string[arrayLength];

        //fill the array
        for (int i = 0; i < arrayLength; i++)
        {
            Console.Write("Please enter element [{0}] of the array: ", i);
            array[i] = Console.ReadLine();
        }

        //sorting the array
        Array.Sort(array, (x,y) => x.Length.CompareTo(y.Length));

        //printing the sorted array
        Console.WriteLine("The sorted array is: ");
       
        for (int i = 0; i < arrayLength; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }
}