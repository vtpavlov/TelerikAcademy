/*
 * Write a program that reads 3 integer numbers 
 * from the console and prints their sum.
*/

using System;

class ThreeIntegersSum
{
    static void Main()
    {
        //Request for integer one input
        Console.Write("Please enter number 1: ");
        int numberOne;
        bool validNumberOne = int.TryParse(Console.ReadLine(), out numberOne);

        //Request for integer two input
        Console.Write("Please enter number 2: ");
        int numberTwo;
        bool validNumberTwo = int.TryParse(Console.ReadLine(), out numberTwo);

        //Request for integer three input
        Console.Write("Please enter number 3: ");
        int numberThree;
        bool validNumberThree = int.TryParse(Console.ReadLine(), out numberThree);

        //check if the numbers are valid integers and then print out the sum
        string result = (validNumberOne && validNumberTwo && validNumberThree) ? "The sum of the numbers is: " +
            (numberOne + numberTwo + numberThree) : "One or more of the numbers are invalid!";
        Console.WriteLine(result);
    }
}

