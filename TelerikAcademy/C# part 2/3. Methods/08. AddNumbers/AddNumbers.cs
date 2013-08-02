/*
 * Write a method that adds two positive integer numbers represented 
 * as arrays of digits (each array element arr[i] contains a digit; 
 * the last digit is kept in arr[0]). Each of the numbers that will 
 * be added could have up to 10 000 digits.
*/


using System;
using System.Text;

class AddNumbers
{
    //method to add two numbers
    static void AddNumber(int[] firstNumber, int[] secondNumber)
    {
        int oneInMind = 0;

        int firstNumberLength = firstNumber.Length;
        int secondNumberLength = secondNumber.Length;
        
        //saves the shorter length in variable length
        int length = firstNumber.Length > secondNumber.Length ? secondNumber.Length : firstNumber.Length;
        
        StringBuilder result = new StringBuilder();

        for (int i = 0; i < length; i++)
        {
            if (firstNumber[i] + secondNumber[i] + oneInMind >= 10)
            {                
                result.Append((firstNumber[i] + secondNumber[i] + oneInMind) % 10);
                oneInMind = 1;
            }
            else
            {
                result.Append(firstNumber[i] + secondNumber[i] + oneInMind);
                oneInMind = 0;
            }
        }
        
        //adding the rest of the numbers
        if (firstNumberLength > secondNumberLength)
        {
            result.Append(firstNumber[secondNumberLength] + oneInMind);
            for (int i = secondNumberLength + 1; i < firstNumberLength; i++)
            {
                result.Append(firstNumber[i]);
            }   
        }
        else
        {
            result.Append(secondNumber[firstNumberLength] + oneInMind);
            for (int i = firstNumberLength; i < secondNumberLength; i++)
            {
                result.Append(secondNumber[i]);
            }
        }

        //reversing the string result
        char[] reversedResult = result.ToString().ToCharArray();
        result.Clear();
        for (int i = reversedResult.Length - 1; i >= 0; i--)
        {
            result.Append(reversedResult[i]);
        }

        //printing the result
        Console.WriteLine(result);
    }


    static void Main()
    {
        //123 459
        int[] firstNumber = { 9, 5, 4, 3, 2, 1 };
        
        //923
        int[] secondNumber = { 3, 2, 9 };
        
        //printing the result from adding the numbers
        AddNumber(firstNumber, secondNumber);
    }
}
