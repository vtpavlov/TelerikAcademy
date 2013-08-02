/*
 * Write a boolean expression for finding if the bit 3 (counting from 0) of a given integer is 1 or 0.
*/

using System;

class ThirdBit
{
    static void Main()
    {
        //Getting string input and converting it to integer
        Console.Write("Please enter a number to check if its third bit is 0 or 1: ");
        int number = int.Parse(Console.ReadLine());

        //boolean expression to check if the third bit is 0 or 1
        bool result = (number >> 3) % 2 == 0;

        //printing the result
        Console.WriteLine("the third bit of the number {0} ({1}) is 0: " + result, Convert.ToString(number, 2).PadLeft(32, '0'), number);
    }
}

