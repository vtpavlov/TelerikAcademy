/*
 * Write a program to convert decimal numbers to their binary representation.
*/


using System;
using System.Collections.Generic;
using System.Text;

class DecimalToBinary
{
    static void Main()
    {
        Console.Write("Please enter decimal number: ");
        int decimalNumber = int.Parse(Console.ReadLine());
        string binaryRepresentation = ConvertToBinary(decimalNumber);
        Console.WriteLine("The binary representation of {0} is: {1}", decimalNumber, binaryRepresentation);
    }

    //Method to convert from decimal to binary
    private static string ConvertToBinary(int decimalNumber)
    {
        if (decimalNumber == 0)
        {
            return "0";
        }

        //List to save the binary representation
        List<byte> result = new List<byte>();
        while (decimalNumber > 0)
        {
            //Adding to the list 0 or 1
            result.Add((byte)(decimalNumber % 2));
            decimalNumber /= 2;
        }

        //Reversing the List
        result.Reverse();

        //StringBuilder to convert the list to String
        StringBuilder resultString = new StringBuilder();
        foreach (byte binaryElement in result)
	    {
		    resultString.Append(binaryElement);
	    }
        return resultString.ToString();
    }
}