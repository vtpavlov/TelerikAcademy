/*
 * Write a program to convert decimal numbers to their hexadecimal representation.
*/


using System;
using System.Collections.Generic;
using System.Text;

class DecimalToHexadecimal
{
    static void Main()
    {
        Console.Write("Please enter decimal number: ");
        int decimalNumber = int.Parse(Console.ReadLine());
        string hexaDecimal = ConvertToHexaDecimal(decimalNumber);
        Console.WriteLine("The hexadecimal representation of {0} is: {1}", decimalNumber, hexaDecimal);
    }

    //Method to convert decimal to hexadecimal
    private static string ConvertToHexaDecimal(int decimalNumber)
    {
        if (decimalNumber == 0)
        {
            return "0";
        }

        //List to save the hexadecimal representation
        List<byte> result = new List<byte>();
        while (decimalNumber > 0)
        {
            //Adding to the list
            result.Add((byte)(decimalNumber % 16));
            decimalNumber /= 16;
        }

        //Reversing the List
        result.Reverse();

        //StringBuilder to convert the list to String
        StringBuilder resultString = new StringBuilder();
        
        //Converting the numbers of the List to String and the members > 10 to A,B...
        foreach (byte hexElement in result)
        {
            if (hexElement < 10)
            {
                resultString.Append(hexElement);    
            }
            else
            {
                resultString.Append((char) (hexElement + 55));
            }            
        }
        return resultString.ToString();
    }
}