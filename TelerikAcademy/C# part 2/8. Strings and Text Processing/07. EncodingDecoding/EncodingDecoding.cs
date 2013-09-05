/*
 * Write a program that encodes and decodes a string using given encryption key (cipher). 
 * The key consists of a sequence of characters. The encoding/decoding is done by performing 
 * XOR (exclusive or) operation over the first letter of the string with the first of the key, 
 * the second – with the second, etc. When the last key character is reached, the next is the first.
*/


using System;
using System.Text;

class EncodingDecoding
{
    static void Main()
    {
        Console.Write("Please enter a string to be encoded: ");
        string encodeString = Console.ReadLine();
        Console.Write("Please enter a key: ");
        string key = Console.ReadLine();
        string encodedString = Encode(key, encodeString);
        Console.WriteLine("The encoded String is: " + encodedString);

        Console.WriteLine("The decoded String is: " + Decode(key, encodedString));
    }

    private static string Decode(string key, string decodeString)
    {
        int keyLength = key.Length;
        int keyInc = 0;
        StringBuilder decodedString = new StringBuilder();
        for (int i = 0; i < decodeString.Length; i++)
        {
            decodedString.Append((char)(decodeString[i] ^ key[keyInc]));
            keyInc++;
            if (keyInc == keyLength)
            {
                keyInc = 0;
            }
        }

        return decodedString.ToString();
    }

    private static string Encode(string key, string encodeString)
    {
        int keyLength = key.Length;
        int keyInc = 0;
        StringBuilder encodedString = new StringBuilder();
        for (int i = 0; i < encodeString.Length; i++)
        {
            encodedString.Append((char)(encodeString[i] ^ key[keyInc]));
            keyInc++;
            if (keyInc == keyLength)
            {
                keyInc = 0;
            }
        }

        return encodedString.ToString();
    }
}
