/* * Write a program that exchanges bits {p, p+1, …, p+k-1) 
 * with bits {q, q+1, …, q+k-1} of given 32-bit unsigned integer.
*/

using System;

class ExchangingBits
{
    static void Main()
    {
       
        Console.WriteLine("==========================================================");
        Console.WriteLine("=    A program that exchange bits {p, p+1, …, p+k-1)     =");
        Console.WriteLine("= with bits {q, q+1, …, q+k-1} of given positive number. =");
        Console.WriteLine("==========================================================\n\n");

        //Getting string input and converting it to unsinged integer
        Console.Write("Please enter a positive number: ");
        uint positiveNumber = uint.Parse(Console.ReadLine());

        //Getting string input and converting it to integer
        Console.Write("Please enter p: ");
        int p = int.Parse(Console.ReadLine());

        //Getting string input and converting it to integer
        Console.Write("Please enter q: ");
        int q = int.Parse(Console.ReadLine());

        //Getting string input and converting it to integer
        Console.Write("Please enter k: ");
        int k = int.Parse(Console.ReadLine());

        //printing the number
        Console.WriteLine("the number is: {0}", Convert.ToString(positiveNumber, 2).PadLeft(32, '0'));

        uint mask;
        uint result = positiveNumber;

        //exchanging bits
        for (int i = 0; i <= k - 1; i++)
        {
            //getting the bit at position p + i (first iteration p , second iteration p+1 etc.)
            //and the bit at position q + i (first iteration q, second iteration q+1 etc.)
            //saving the bit at position p in firstBit and the bit in position q at secondBit
            int firstBit = (result >> (p + i)) % 2 != 0 ? 1 : 0;
            int secondBit = (result >> (q + i)) % 2 != 0 ? 1 : 0;

            //checking the value of the secondBit(the bit at position q) if it's 0 changing the p-th bit to 0
            //if it's 1 changing the bit to 1
            if (secondBit == 0)
            {
                mask = ~(1u << (p + i));
                result = result & mask;
            }
            else if (secondBit == 1)
            {
                mask = 1u << (p + i);
                result = result | mask;
            }

            //checking the value of the firstBit(the bit at position p) if it's 0 changing the bit at position q to 0
            //if it's 1 changing to 1
            if (firstBit == 0)
            {
                mask = ~(1u << (q + i));
                result = result & mask;
            }
            else if (firstBit == 1)
            {
                mask = 1u << (q + i);
                result = result | mask;
            }
        }

        //printing the new number
        Console.WriteLine("the new number is: {0} ({1})", Convert.ToString(result, 2).PadLeft(32, '0'), result);
    }
}