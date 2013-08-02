/*
 * Write methods to calculate minimum, maximum, average, 
 * sum and product of given set of integer numbers. Use variable number of arguments.
*/


using System;

class NumberOperations
{
    static int Minimum(int[] integers)
    {
        int minimum = int.MaxValue;
        for (int i = 0; i < integers.Length; i++)
        {
            if (integers[i] <= minimum)
            {
                minimum = integers[i];
            }
        }
        return minimum;
    }

    static int Maximum(int[] integers)
    {
        int maximum = int.MinValue;
        for (int i = 0; i < integers.Length; i++)
        {
            if (integers[i] >= maximum)
            {
                maximum = integers[i];
            }
        }
        return maximum;
    }

    static double Average(int[] integers)
    {
        int sum = 0;

        for (int i = 0; i < integers.Length; i++)
        {
            sum += integers[i];
        }

        return (double)sum / integers.Length;
    }

    static int Sum(int[] integers)
    {
        int sum = 0;

        for (int i = 0; i < integers.Length; i++)
        {
            sum += integers[i];
        }

        return sum;
    }

    static int Product(int[] integers)
    {
        int product = 0;

        for (int i = 0; i < integers.Length; i++)
        {
            product *= integers[i];
        }

        return product;
    }

    static void Main()
    {
    }
}