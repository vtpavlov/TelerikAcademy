/*
 * Write a method that reverses the digits of given decimal number. 
 * Example: 256  652
*/


using System;
using System.Text;

class DigitReverse
{
    static void ReverseDigit(ref int number)
    {
        //making number as string and splitting it to char symbols
        char[] digits = number.ToString().ToCharArray();

        //string builder to append the chars from last to the first
        StringBuilder result = new StringBuilder();
        
        for (int i = digits.Length - 1; i >= 0; i--)
        {
            result.Append(digits[i]);
        }
        
        //saving the new number as integer
        number = int.Parse(result.ToString());
    }

    static void Main()
    {
        Console.Write("Please enter a number: ");
        int number = int.Parse(Console.ReadLine());
        ReverseDigit(ref number);
        Console.WriteLine("The number with reversed digits is: " + number);
    }
}
