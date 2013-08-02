/*
 * Write a program that reads two positive integer numbers 
 * and prints how many numbers p exist between them such 
 * that the reminder of the division by 5 is 0 (inclusive). 
 * Example: p(17,25) = 2.
*/

using System;

class NumbersBetween
{
    static void Main()
    {
        //Request for integer one input
        Console.Write("Please enter number 1 which should be smaller then number 2: ");
        uint numberOne;
        bool validNumberOne = uint.TryParse(Console.ReadLine(), out numberOne);

        //Request for integer two input
        Console.Write("Please enter number 2: ");
        uint numberTwo;
        bool validNumberTwo = uint.TryParse(Console.ReadLine(), out numberTwo);

        //numbers p existing between the other 2 numbers such that the reminder of the division 5 is 0
        int numbersBetween = 0;

        //for cycle to check which numbers fits the description and if the input is correct
        for (uint i = numberOne; i <= numberTwo; i++)
        {
            numbersBetween += ((validNumberOne && validNumberTwo) && (i % 5 == 0)) ? 1 : 0;
        }

        //printing the result
        Console.WriteLine("The numbers between the other 2 which can be devided by 5 without reminder are: " + numbersBetween);
    }
}
