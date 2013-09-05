/*
 * Write a program to convert hexadecimal numbers to binary numbers (directly).
*/


using System;
using System.Text;

class HexadecimalToBinary
{
    static void Main()
    {
        Console.Write("Please enter hexadecimal number: ");
        string hexadecimalNumber = Console.ReadLine();
        string binaryRepresentation = ConvertToBinaryFromHex(hexadecimalNumber);
        Console.WriteLine("The binary representation of {0} is: {1}", hexadecimalNumber, binaryRepresentation);
    }

    //Method to convert to binary from hexadecimal
    private static string ConvertToBinaryFromHex(string hexadecimalNumber)
    {
        hexadecimalNumber = hexadecimalNumber.ToUpper();
        //Array with binary representation of hexadecimal digits
        string[] hexDigits = { "0000", "0001", "0010", "0011", "0100", "0101", "0110", "0111", "1000"
                                 , "1001", "1010", "1011", "1100","1101", "1110", "1111" };
        
        //StringBuilder to hold the result
        StringBuilder result = new StringBuilder();

        //Appending to the string Builder
        foreach (char element in hexadecimalNumber)
        {
            if (element > 64)
            {
                result.Append(hexDigits[(element - 55)]);
            }
            else
            {
                result.Append(hexDigits[int.Parse(element.ToString())]);
            }
        }

        return result.ToString();
    }
}