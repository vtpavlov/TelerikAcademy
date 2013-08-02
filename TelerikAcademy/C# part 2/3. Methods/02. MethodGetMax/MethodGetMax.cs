/*
 * Write a method GetMax() with two parameters that returns the bigger of two integers. 
 * Write a program that reads 3 integers from the console and 
 * prints the biggest of them using the method GetMax().
*/


using System;

class MethodGetMax
{
    //method to find the biggest of two integers
    static int GetMax(int first, int second)
    {
        if (first > second)
        {
            return first;
        }
        else
        {
            return second;
        }
    }

    static void Main()
    {
        //getting integers input
        Console.Write("Please enter the first integer: ");
        int firstNumber = int.Parse(Console.ReadLine());

        Console.Write("Please enter the second integer: ");
        int secondNumber = int.Parse(Console.ReadLine());

        Console.Write("Please enter the third integer: ");
        int thirdNumber = int.Parse(Console.ReadLine());

        //finding the biggest integer using GetMax
        int biggestNumber = GetMax(thirdNumber, GetMax(firstNumber, secondNumber));

        //printing the result
        Console.WriteLine("The biggest integer is: {0}", biggestNumber);
    }
}
