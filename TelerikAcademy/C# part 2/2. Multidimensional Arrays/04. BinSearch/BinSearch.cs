/*
 * Write a program, that reads from the console an array of N integers and an integer K, 
 * sorts the array and using the method Array.BinSearch() finds the largest 
 * number in the array which is ≤ K. 
*/

using System;

class BinSearch
{
    static void Main()
    {
        //getting console input
        Console.Write("Please enter integer K: ");
        int integerK = int.Parse(Console.ReadLine());

        Console.Write("Please enter length of the array: ");
        int length = int.Parse(Console.ReadLine());

        int[] array = new int[length];

        //fill the array
        for (int i = 0; i < length; i++)
        {
            Console.Write("Please enter element [{0}] of the array: ", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        //sorting the array
        Array.Sort(array);

        //printing the sorted array
        Console.WriteLine("Sorted array: ");
        for (int i = 0; i < length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();

        int indexOfTheLargestNumber = 0;
        bool allElementsAreBigger = true;
        for (int i = 0; i < length; i++)
        {
            if (integerK >= array[i])
            {
                allElementsAreBigger = false;
            }
        }
        //finding the largest number <= K with binSearch
        while (true)
        {
            if (allElementsAreBigger)
            {
                break;
            }

            if (Array.BinarySearch(array, integerK) >= 0)
            {
                indexOfTheLargestNumber = Array.BinarySearch(array, integerK);
                break;
            }
            integerK--;
        }

        //printing the result
        if (allElementsAreBigger)
        {
            Console.WriteLine("All elements are bigger then K.");
        }
        else
        {
            Console.WriteLine("The largest number <= K is: {0} , and his index is: {1}."
               , array[indexOfTheLargestNumber], indexOfTheLargestNumber);
        }        
    }
}