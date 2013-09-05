/*
 * Write a program to convert binary numbers to their decimal representation
*/

using System;
using System.Collections.Generic;

class BinaryToDecimal
{
    static void Main()
    {
        Console.Write("Please enter binary number: ");
        string binaryNumber = Console.ReadLine();
        long decimalRepresentation = ConvertToDecimal(binaryNumber);
        Console.WriteLine("The decimal representation of {0} is: {1}", binaryNumber, decimalRepresentation);
    }

    //Method to convert binary to decimal
    private static long ConvertToDecimal(string binaryNumber)
    {
        //Variable holding the decimal number
        long sum = 0;

        //List with the bits of the binaryNumber
        List<byte> binary = new List<byte>();

        //Adding to the list
        foreach (char bit in binaryNumber)
        {
            binary.Add(byte.Parse(bit.ToString()));
        }

        //Reversing the list
        binary.Reverse();
        
        //Calculating the decimal number
        for (int i = 0; i < binary.Count; i++)
        {
            sum += binary[i] * (int)Math.Pow(2, (double)i);
        }

        return sum;
    }
}
