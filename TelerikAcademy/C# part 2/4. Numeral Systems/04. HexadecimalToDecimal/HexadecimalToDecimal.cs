/*
 * Write a program to convert hexadecimal numbers to their decimal representation.
*/


using System;
using System.Collections.Generic;

class HexadecimalToDecimal
{
    static void Main()
    {
        Console.Write("Please enter hexadecimal number: ");
        string hexadecimalNumber = Console.ReadLine();
        long decimalRepresentation = ConvertToDecimalFromHex(hexadecimalNumber);
        Console.WriteLine("The decimal representation of {0} is: {1}", hexadecimalNumber, decimalRepresentation);
    }

    private static long ConvertToDecimalFromHex(string hexadecimalNumber)
    {
        //Variable holding the decimal number
        long sum = 0;
        hexadecimalNumber = hexadecimalNumber.ToUpper();
        //List with the elements of the hexadecimalNumber
        List<byte> hexadecimal = new List<byte>();

        //Adding to the list
        foreach (char element in hexadecimalNumber)
        {
            if (element > 64)
            {
                hexadecimal.Add((byte)(element - 55));
            }
            else
            {
                hexadecimal.Add(byte.Parse(element.ToString())); 
            }
            
        }

        //Reversing the list
        hexadecimal.Reverse();

        //Calculating the decimal number
        for (int i = 0; i < hexadecimal.Count; i++)
        {
            sum += hexadecimal[i] * (int)Math.Pow(16, (double)i);
        }

        return sum;
    }
}