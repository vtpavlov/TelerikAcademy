/*
 * Write a program that finds the index of given element 
 * in a sorted array of integers by using the binary search algorithm 
 * (find it in Wikipedia).
*/

using System;

class BinarySearch
{
    static void Main()
    {
        Console.Write("Enter array's length: ");
        int n = int.Parse(Console.ReadLine());

        int[] data = new int[n];

        //Fill the array
        for (int i = 0; i < n; i++)
        {
            Console.Write("Please enter element {0}: ", i);
            data[i] = int.Parse(Console.ReadLine());
        }

        //asking for element
        Console.Write("Please enter element to search for: ");
        int element = int.Parse(Console.ReadLine());

        //sorting the array
        Array.Sort(data);

        //printing the sorted array
        Console.WriteLine();
        Console.WriteLine("This is the sorted array:");
        for (int i = 0; i < n; i++)
        {
            Console.Write("Index: " + i + "; Element: " + data[i] + "\n");           
        }

        int low = 0; // low end of the search area
        int high = data.Length - 1; // high end of the search area
        int middle = (low + high + 1) / 2; // middle element
        int index = -1;

        do // loop to search for element
        {
            // if the element is found at the middle
            if (element == data[middle])
            {
                index = middle;
            }
            // middle element is too high
            else if (element < data[middle])
            {
                high = middle - 1; // eliminate the higher half
            }
            else // middle element is too low
            {
                low = middle + 1; // eliminate the lower half
            }
            middle = (low + high + 1) / 2; // recalculate the middle
        } while ((low <= high) && (index == -1));

        Console.WriteLine();
        Console.Write("This is the index of the searched element: ");
        if (index != -1)
        {
            Console.WriteLine(index);    
        }
        else
        {
            Console.WriteLine("No such element in the array!");
        }        
    }
}