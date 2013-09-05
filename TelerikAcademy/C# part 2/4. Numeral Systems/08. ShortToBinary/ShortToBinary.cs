/*
 * Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).
*/


using System;
using System.Collections.Generic;
using System.Text;

class ShortToBinary
{
    static void Main()
    {
        Console.Write("Please enter 16-bit signed integer number: ");
        short number = short.Parse(Console.ReadLine());
        string result = ConvertShortToBinary(number);
        Console.WriteLine("The binary representation of the number {0} is: {1}", number, result);
    }

    private static string ConvertShortToBinary(short number)
    {
        if (number >= 0)
        {
            return ConvertToBinary(number);
        }
        else
        {
            int absNumber = Math.Abs(number) - 1;
            //List to save the binary representation
            List<byte> result = new List<byte>();
            while (absNumber > 0)
            {
                //Adding to the list 0 or 1                
                if (absNumber % 2 == 0)
                {
                    result.Add(1);
                }
                else
                {
                    result.Add(0);
                }
                absNumber /= 2;
            }

            //Reversing the List
            if (result.Count < 16)
            {
                for (int i = result.Count + 1; i <= 16; i++)
                {
                    result.Add(1);
                }
            }
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

    //Method to convert from decimal to binary
    private static string ConvertToBinary(int decimalNumber)
    {
        if (decimalNumber == 0)
        {
            return "0000000000000000";
        }

        //List to save the binary representation
        List<byte> result = new List<byte>();
        while (decimalNumber > 0)
        {
            //Adding to the list 0 or 1
            result.Add((byte)(decimalNumber % 2));
            decimalNumber /= 2;
        }
        if (result.Count < 16)
        {
            for (int i = result.Count + 1; i <= 16; i++)
            {
                result.Add(0);
            }
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