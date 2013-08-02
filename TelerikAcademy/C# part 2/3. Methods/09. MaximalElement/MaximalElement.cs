/*
 * Write a method that return the maximal element in a 
 * portion of array of integers starting at given index. 
 * Using it write another method that sorts an array 
 * in ascending / descending order.
*/


using System;

class MaximalElement
{
    //getting the index of the max element
    static int MaxElement(int startingIndex, int[] array)
    {
        int maxElement = startingIndex;
        for (int i = startingIndex; i < array.Length; i++)
        {
            if (array[i] >= array[maxElement])
            {
                maxElement = i;
            }
        }
        return maxElement;
    }

    //sorting the array
    static void SortArray(int[] array, bool ascending)
    {
        if (ascending)
        {
            int[] tempArray = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                int maxElement = MaxElement(i, array);
                int temp = array[i];
                array[i] = array[maxElement];
                array[maxElement] = temp;                
            }
            array.CopyTo(tempArray, 0);
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = tempArray[array.Length - i - 1];
            }
        }
        else
        {
            for (int i = 0; i < array.Length; i++)
            {
                int maxElement = MaxElement(i, array);
                int temp = array[i];
                array[i] = array[maxElement];
                array[maxElement] = temp;
            }
        }
    }

    static void Main()
    {
        int[] array = { 1, 5, 4, 2, 6, 8, 78 };

        //true for ascending and false for descending
        SortArray(array, false);       
        
        //printing the array after sort
        foreach (var element in array)
        {
            Console.Write(element + " ");
        }
    }
}