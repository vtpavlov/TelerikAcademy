/*
 * Write a program to convert from any numeral system of 
 * given base s to any other numeral system of base d (2 ≤ s, d ≤  16).
*/


using System;
using System.Collections.Generic;
using System.Text;

class AnyNumeralSystem
{
    static void Main()
    {
        Console.Write("Please enter the base of the numeral system: ");
        int s = int.Parse(Console.ReadLine());
        Console.Write("Please enter the number that u want to convert: ");
        string number = Console.ReadLine();
        Console.Write("Please enter the base of the next numeral system: ");
        int d = int.Parse(Console.ReadLine());
        if (s < 2 || s > 16 || d > 16)
        {
            Console.WriteLine("Wrong input!");
        }
        long toDecimal = ConvertToDecimal(number, s);
        string result = ConvertToAnyNumSys(toDecimal, d);
        Console.WriteLine("The number with numeral system with base {0} is: {1}, and his representation\n" 
            + "in numeral system with base {2} is: {3}", s, number, d, result);
    }

    //Method to convert to decimal
    private static long ConvertToDecimal(string number, int s)
    {
        number = number.ToUpper();
        //Variable holding the decimal number
        long sum = 0;

        //List with the elements of the number
        List<byte> basedS = new List<byte>();

        //Adding to the list
        foreach (char element in number)
        {
            if (element > 64)
            {
                basedS.Add((byte)(element - 55));
            }
            else
            {
                basedS.Add(byte.Parse(element.ToString()));
            }

        }

        //Reversing the list
        basedS.Reverse();

        //Calculating the decimal number
        for (int i = 0; i < basedS.Count; i++)
        {
            sum += basedS[i] * (int)Math.Pow(s, (double)i);
        }

        return sum;
    }

    //Method to convert decimal to any numeral system
    private static string ConvertToAnyNumSys(long decimalNumber, int d)
    {
        if (decimalNumber == 0)
        {
            return "0";
        }
       
        List<byte> result = new List<byte>();
        while (decimalNumber > 0)
        {
            //Adding to the list
            result.Add((byte)(decimalNumber % d));
            decimalNumber /= d;
        }

        //Reversing the List
        result.Reverse();

        //StringBuilder to convert the list to String
        StringBuilder resultString = new StringBuilder();

        //Converting the numbers of the List to String and the members > 10 to A,B...
        foreach (byte element in result)
        {
            if (element < 10)
            {
                resultString.Append(element);
            }
            else
            {
                resultString.Append((char)(element + 55));
            }
        }
        return resultString.ToString();
    }
}