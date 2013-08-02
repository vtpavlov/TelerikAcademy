/*
 * Write a program that sorts an array of strings using the quick sort algorithm (find it in Wikipedia).
*/

using System;

class QuickSort
{
    static int Partition(string[] stringArr, int p, int r)
    {
        string x = stringArr[r];
        int i = p - 1;
        string temp = "";
        for (int j = p; j < r; j++)
        {
            if (string.Compare(stringArr[j], x) < 0)
            {
                i = i + 1;
                temp = stringArr[i];
                stringArr[i] = stringArr[j];
                stringArr[j] = temp;
            }
        }

        temp = stringArr[i + 1];
        stringArr[i + 1] = stringArr[r];
        stringArr[r] = temp;

        return i + 1;
    }

    static void QuickSorting(string[] stringArr, int p, int r)
    {
        if (p < r)
        {
            int q = Partition(stringArr, p, r);
            QuickSorting(stringArr, p, q - 1);
            QuickSorting(stringArr, q + 1, r);
        }
    }
    static void Main()
    {
        string[] stringArr = { "bc", "abcd", "c", "abd", "ad", "abc", "abvded" };
        QuickSorting(stringArr, 0, stringArr.Length - 1);

        for (int i = 0; i < stringArr.Length; i++)
        {
            Console.Write(stringArr[i] + " ");
        }
        Console.WriteLine();
    }
}
