/*
 * Write a method that checks if the element
 * at given position in given array of integers 
 * is bigger than its two neighbors (when such exist).
*/


using System;

class BiggerThanNeighbours
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

    static void Main()
    {
        int[] array = { 1, 1, 1, 2, 34, 4, 3, 2, 4, 5, 2, 3, 5, 6, 7, 7, 8, 5, 4, 2, 4, 6, 7, 5, 23, 3 };

        Console.WriteLine("The array is: 1, 1, 1, 2, 34, 4, 3, 2, 4, 5, 2, 3, 5, 6, 7, 7, 8, 5, 4, 2, 4, 6, 7, 5, 23, 3");

        if (IsBiggerThanNeighbours(4,array))
        {
            Console.WriteLine("The element of position 4 is bigger then it's neighbours");
        }
        else
        {
            Console.WriteLine("The element of position 4 is not bigger then it's neighbours");
        }
    }
}
