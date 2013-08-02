/*
 * Write an expression that extracts from a given integer i 
 * the value of a given bit number b. Example: i=5; b=2 -> value=1.
*/

using System;

class BitExtraction
{
    static void Main()
    {
        //Getting string input and converting it to integer
        Console.Write("Please enter a number to check the value of a bit: ");
        int number = int.Parse(Console.ReadLine());

        //Getting string input for position b and converting it to integer
        Console.Write("Please enter a position of the bit that u want to check: ");
        int b = int.Parse(Console.ReadLine());

        //boolean expression to check if the bit is 0 or 1
        string result = (number >> b) % 2 != 0 ? "1" : "0";

        //printing the result
        Console.WriteLine("the bit of the number {0} ({1}) at position {2} is: " + result, Convert.ToString(number, 2).PadLeft(32, '0'), number, b);
    }
}
