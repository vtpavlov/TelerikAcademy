/*
 * Write a program that reads two arrays from the console and compares them element by element.
*/

using System;

class ArrayCompare
{
    static void Main()
    {
        Console.Write("Enter the length of the first array: ");
        byte n = byte.Parse(Console.ReadLine());
        Console.Write("Enter the length of the second array: ");
        byte m = byte.Parse(Console.ReadLine());
        int[] firstArray = new int[n];
        int[] secondArray = new int[m];
        bool isEqual = true;

        // entering the elements of the arrays
        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter element {0} of the first array: ", i);
            firstArray[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < m; i++)
        {
            Console.Write("Enter element {0} of the second array: ", i);
            secondArray[i] = int.Parse(Console.ReadLine());
        }

        //ckeck the length of the arrays
        if (n != m)
        {
            isEqual = false;
                      
        }
        else //checking if the arrays are equal element by element
        {
            for (int i = 0; i < n; i++)
            {
                if (firstArray[i] != secondArray[i])
                {
                    isEqual = false;
                }
            }
        }
        Console.WriteLine();
        if (isEqual)
        {
            Console.WriteLine("The first and the second arrays are equal.");
        }
        else
        {
            Console.WriteLine("The arrays are not equal.");
        }        
    }
}