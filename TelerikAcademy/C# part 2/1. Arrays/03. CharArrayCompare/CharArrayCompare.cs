/*
 * Write a program that compares two char arrays lexicographically (letter by letter).
*/

using System;

class CharArrayCompare
{
    static void Main()
    {
        Console.Write("Please enter length of the two arrays: ");
        byte arraysLength = byte.Parse(Console.ReadLine());        
        char[] firstArray = new char[arraysLength];
        char[] secondArray = new char[arraysLength];
        bool isEqual = true;

        // get the element of the arrays
        for (int i = 0; i < arraysLength; i++)
        {
            Console.Write("Enter the element {0} of the first array: ", i);
            firstArray[i] = char.Parse(Console.ReadLine());
            Console.Write("Enter the element {0} of the second array: ", i);
            secondArray[i] = char.Parse(Console.ReadLine());
        
            //compare of elements
            if (firstArray[i] != secondArray[i])
            {
                isEqual = false;
            }
        }

        //check if isEqual is true
        if (isEqual)
        {
            Console.WriteLine("The arrays are equal.");
        }
        else
        {
            Console.WriteLine("The arrays are not equal.");
        }
    }
}
