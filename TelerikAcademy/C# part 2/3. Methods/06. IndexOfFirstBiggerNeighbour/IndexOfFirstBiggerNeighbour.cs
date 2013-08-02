/*
 * Write a method that returns the index of the first element in 
 * array that is bigger than its neighbors, or -1, if there’s no such element.
 * Use the method from the previous exercise.
*/


using System;

class IndexOfFirstBiggerNeighbour
{
    static bool IsBiggerThanNeighbours(int position, int[] array)
    {
        // if there are no two neighbours, the method return false because the element at the given position
        // is not bigger then it's neighbours
        // and also return false if the neighbours are smaller or equal to the element
        if (position >= 1 && position <= array.Length - 2)
        {
            if (array[position] > array[position - 1] && array[position] > array[position + 1])
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        else
        {
            return false;
        }
    }

    //method to find the first bigger then it's two neighbours number
    static int FirstBiggerThanNeighbours(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (IsBiggerThanNeighbours(i, array))
            {
                return i;
            }
        }
        return -1;
    }

    //testing the method
    static void Main()
    {
        int[] array = { 1, 1, 1, 2, 34, 4, 3, 2, 4, 5, 2, 3, 5, 6, 7, 7, 8, 5, 4, 2, 4, 6, 7, 5, 23, 3 };

        Console.WriteLine("The array is: 1, 1, 1, 2, 34, 4, 3, 2, 4, 5, 2, 3, 5, 6, 7, 7, 8, 5, 4, 2, 4, 6, 7, 5, 23, 3");

        int index = FirstBiggerThanNeighbours(array);
        if (index != -1)
        {
            Console.WriteLine("The first element that is bigger then it's two neighbours is: {0} and his index is: {1}"
                , array[index], index);
        }
        else
        {
            Console.WriteLine("There is no element bigger then it's two neighbours.");
        }
    }
}