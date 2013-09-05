/*
 * Write a program to convert binary numbers to hexadecimal numbers (directly).
*/


using System;
using System.Collections.Generic;
using System.Text;

class BinaryToHexadecimal
{
    static void Main()
    {
        Console.Write("Please enter binary number: ");
        string binaryNumber = Console.ReadLine();
        string hexadecimal = ConvertToHexadecimal(binaryNumber);
        Console.WriteLine("The hexadecimal representation of {0} is: {1}", binaryNumber, hexadecimal);
    }

    private static string ConvertToHexadecimal(string binaryNumber)
    {
        //HexDigits represented in binary
        string[] hexDigits = { "0000", "0001", "0010", "0011", "0100", "0101", "0110", "0111", "1000"
                                 , "1001", "1010", "1011", "1100","1101", "1110", "1111" };
        
        //Converting the string to List
        List<char> binaryToList = new List<char>();
        
        foreach (var element in binaryNumber)
        {
            binaryToList.Add(element);
        }

        //Reversing it
        binaryToList.Reverse();
        
        //Adding zeroes to the end until we have count of binary digits that satisfy us 4, 8 , 16, etc..
        while ((binaryToList.Count % 4) != 0)
        {
            binaryToList.Add('0');
        }

        //Reversing again
        binaryToList.Reverse();
        
        //List to save the hexadecimal digits of the number
        List<byte> hexadecimalList = new List<byte>();

        //StringBuilder that we clear when he gets 4 digits
        StringBuilder fourDigits = new StringBuilder();
        
        //Checking if fourDigits equals some of the elements in hexDigits and save in hexadecimalList it's index
        foreach (var element in binaryToList)
        {
            fourDigits.Append(element);
            if (fourDigits.Length == 4)
            {
                for (int i = 0; i < hexDigits.Length; i++)
                {
                    if (fourDigits.ToString().Equals(hexDigits[i]))
                    {
                        hexadecimalList.Add((byte)i);
                    }
                }
                fourDigits.Clear();
            }            
        }

        //StringBuilder to hold the result
        StringBuilder resultString = new StringBuilder();
        
        //Converting the numbers to hexadecimal digits. Example: 1 -> 1, 10 -> A, 11 -> B, etc.
        foreach (byte hexElement in hexadecimalList)
        {
            if (hexElement < 10)
            {
                resultString.Append(hexElement);
            }
            else
            {
                resultString.Append((char)(hexElement + 55));
            }
        }

        return resultString.ToString();
    }
}
