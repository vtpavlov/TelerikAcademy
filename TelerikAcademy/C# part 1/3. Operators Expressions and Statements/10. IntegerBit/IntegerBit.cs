/*
 * Write a boolean expression that returns if the bit 
 * at position p (counting from 0) in a given integer 
 * number v has value of 1. Example: v=5; p=1 -> false.
*/


using System;

class IntegerBit
{
    static void Main()
    {
        //Getting string input and converting it to integer
        Console.Write("Please enter a number to check if it's p bit is 1: ");
        int number = int.Parse(Console.ReadLine());

        //Getting string input for position and converting it to integer
        Console.Write("Please enter a position of the bit that u want to check: ");
        int position = int.Parse(Console.ReadLine());

        //boolean expression to check if the bit at position=position is 1
        bool result = (number >> position) % 2 != 0;

        //printing the result
        Console.WriteLine("the bit of the number {0} ({1}) at position {2} is 1: " + result, Convert.ToString(number, 2).PadLeft(32, '0'), number, position);
    }
}

