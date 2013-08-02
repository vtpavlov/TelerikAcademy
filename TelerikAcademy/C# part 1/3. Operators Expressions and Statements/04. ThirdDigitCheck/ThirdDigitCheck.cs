/*
 * Write an expression that checks for given integer if its third digit (right-to-left) is 7. E. g. 1732 -> true.
*/

using System;

class ThirdDigitCheck
{
    static void Main()
    {
        //Getting string input and converting it to integer
        Console.Write("Please enter a number to check if it's third digit is 7: ");
        int number = int.Parse(Console.ReadLine());

        //expression that checks if the third digit of an integer is 7
        bool result = (number / 100) % 10 == 7;

        //printing the result
        Console.WriteLine("The third digit of the number is 7: " + result);
    }
}

