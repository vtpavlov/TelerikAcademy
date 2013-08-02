/*
 * Write a program that reads two numbers N and K and generates all the 
 * combinations of K distinct elements from the set [1..N]. 
 * Example: N = 5, K = 2  {1, 2}, {1, 3}, {1, 4}, {1, 5}, 
 * {2, 3}, {2, 4}, {2, 5}, {3, 4}, {3, 5}, {4, 5}
*/

using System;

class Combinations
{
    static void Check(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + 1 + (i == arr.Length - 1 ? "\n" : " "));
        }
    }

    static void Combination(int[] arr, int n, int i, int next)
    {
        if (i == arr.Length)
        {
            Check(arr);
            return;
        }

        for (int j = next; j < n; j++)
        {
            arr[i] = j;
            Combination(arr, n, i + 1, j + 1);
        }
    }

    static void Main()
    {
        Console.Write("Please enter N: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter K: ");
        int[] arr = new int[int.Parse(Console.ReadLine())];
        Combination(arr, n, 0, 0);
    }
}