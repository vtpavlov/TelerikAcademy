/*
 * Write a program that shows the internal binary representation 
 * of given 32-bit signed floating-point number in IEEE 754 format (the C# type float). 
 * Example: -27,25  sign = 1, exponent = 10000011, mantissa = 10110100000000000000000.
*/


using System;
using System.Text;

class FloatToBinary
{

    public static void Main()
    {
        //Getting 32-bit signed floating-point number
        Console.Write("Please enter 32-bit floating point number: ");
        float number = float.Parse(Console.ReadLine());

        //Converting it to hex
        byte[] arrayOfBytes = BitConverter.GetBytes(number);
        Array.Reverse(arrayOfBytes);
        string hexResult = BitConverter.ToString(arrayOfBytes);

        //Array with binary representation of hexadecimal digits
        string[] hexDigits = { "0000", "0001", "0010", "0011", "0100", "0101", "0110", "0111", "1000"
                                 , "1001", "1010", "1011", "1100","1101", "1110", "1111" };

        //StringBuilder to hold the binary result
        StringBuilder binaryFloat = new StringBuilder();

        //Appending to the StringBuilder
        foreach (char element in hexResult)
        {
            if (element > 64 && element != '-')
            {
                binaryFloat.Append(hexDigits[(element - 55)]);
            }
            else if(element != '-')
            {
                binaryFloat.Append(hexDigits[int.Parse(element.ToString())]);
            }
        }

        //print floating point number
        Console.Write("Sign:");
        for (int i = 0; i < binaryFloat.Length; i++)
        {
            Console.Write(binaryFloat[i]);
            if (i == 0)
            {

                Console.Write(" Exponent:");
            }
            if (i == 8)
            {
                Console.Write(" Mantissa:");
            }
        }
        Console.WriteLine();
    }
}