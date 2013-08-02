/*
 * Write a program to calculate n! for each n in the range [1..100]. 
 * Hint: Implement first a method that multiplies a number 
 * represented as array of digits by given integer number. 
*/


using System;
using System.Text;

class NFactorial
{
    static int[] AddNumber(int[] firstNumber, int[] secondNumber)
    {
        int oneInMind = 0;

        int firstNumberLength = firstNumber.Length;
        int secondNumberLength = secondNumber.Length;

        //saves the shorter length in variable length
        int length = firstNumber.Length > secondNumber.Length ? secondNumber.Length : firstNumber.Length;

        StringBuilder result = new StringBuilder();

        for (int i = 0; i < length; i++)
        {
            if (firstNumber[firstNumberLength - 1 - i] + secondNumber[secondNumberLength - 1 - i] + oneInMind >= 10)
            {
                result.Append((firstNumber[firstNumberLength - 1 - i] + secondNumber[secondNumberLength - 1 - i] + oneInMind) % 10);
                oneInMind = 1;
            }
            else
            {
                result.Append(firstNumber[firstNumberLength - 1 - i] + secondNumber[secondNumberLength - 1 - i] + oneInMind);
                oneInMind = 0;
            }
        }

        //adding the rest of the numbers
        if (firstNumberLength > secondNumberLength)
        {
            result.Append(firstNumber[(firstNumberLength - 1) - secondNumberLength] + oneInMind);
            for (int i = firstNumberLength - 2 - secondNumberLength; i >= 0; i--)
            {
                result.Append(firstNumber[i]);
            }
        }
        else if(firstNumberLength < secondNumberLength)
        {
            result.Append(secondNumber[(secondNumberLength - 1) - firstNumberLength] + oneInMind);
            for (int i = secondNumberLength - 2 - firstNumberLength; i >= 0; i--)
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


        int[] numberResult = new int[result.Length];
        for (int i = 0; i < result.Length; i++)
        {
            numberResult[i] = int.Parse(result[i].ToString());
        }

        return numberResult;
    }

    static int[] multiplyNumber(int[] firstNumber, int secondNumber)
    {
        StringBuilder temp = new StringBuilder();        
        int spacing = 0;
        int[][] arrayToCalculate = new int[firstNumber.Length][];

        for (int i = firstNumber.Length - 1; i >= 0; i--)
        {
            temp.Append(firstNumber[i] * secondNumber);
            temp.Append(new string('0',spacing));
            spacing++;
            arrayToCalculate[i] = new int[temp.Length];            
            for (int j = 0; j < temp.Length; j++)
            {
                arrayToCalculate[i][j] = int.Parse(temp[j].ToString());
            }
            temp.Clear();
        }

        int[] numericResult = new int[arrayToCalculate[0].Length];
        arrayToCalculate[0].CopyTo(numericResult, 0);
        for (int i = 1; i < firstNumber.Length; i++)
        {
            int[] temporaryArray = AddNumber(numericResult, arrayToCalculate[i]);
            numericResult = new int[temporaryArray.Length];
            temporaryArray.CopyTo(numericResult, 0);
        }

        return numericResult;
    }

    static void PrintFactorial(int[] array, int index,int recursiveSteps)
    {
        if (index <= recursiveSteps)
        {
            Console.Write("{0}! = ", index - 1);
            foreach (var item in array)
            {
                Console.Write(item);
            }
            Console.Write(";\n");
            int newIndex = index + 1;
            PrintFactorial(multiplyNumber(array, index), newIndex, recursiveSteps);
        }
    }

    static void Main()
    {
        //[1 - 30] ,for [1 - 100] change to 100
        int numberOfFactorials = 30;
        PrintFactorial(new int[1] {1}, 2, numberOfFactorials + 1);
    }
}