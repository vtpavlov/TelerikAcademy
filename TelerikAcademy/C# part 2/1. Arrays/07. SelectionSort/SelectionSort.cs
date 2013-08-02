/*
 * Sorting an array means to arrange its elements in increasing order. 
 * Write a program to sort an array. Use the "selection sort" algorithm: 
 * Find the smallest element, move it at the first position, 
 * find the smallest from the rest, move it at the second position, etc.
*/


using System;

class SelectionSort
{
    static void Main()
    {
        Console.Write("Enter array's length: ");
        int n = int.Parse(Console.ReadLine());
        
        int[] array = new int[n];       
        int holder = 0;
        
        //Fill the array
        for (int i = 0; i < n; i++)
        {
            Console.Write("Please enter element {0} of the array: ", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        //printing the array before the sort
        Console.Write("Unsorted Array: ");
        for (int i = 0; i < n; i++)
        {
            Console.Write(array[i] + " ");
        }

        //sorting the array with selection sort algorithm
        for (int i = 0; i < n - 1; i++)
        {            
            for (int j = i + 1; j < n; j++)
            {
                if (array[j] < array[i])
                {
                    holder = array[i];
                    array[i] = array[j];
                    array[j] = holder;
                }
            }
        }

        //printing the sorted array
        Console.WriteLine();        
        Console.Write("Sorted Array: ");
        for (int i = 0; i < n; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }
}
