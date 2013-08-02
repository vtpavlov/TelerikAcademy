/*
 * Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.
 * 
 * 
 * I tested with number 56 (111000) where bits 3,4 and 5 are 1 and it works correct
*/

using System;

class ThreeBitsExchange
{
    static void Main()
    {
        //Getting string input and converting it to unsinged integer
        Console.Write("Please enter a positive number: ");
        uint positiveNumber = uint.Parse(Console.ReadLine());

        //printing the number
        Console.WriteLine("the number is: {0}", Convert.ToString(positiveNumber, 2).PadLeft(32, '0'));

        uint mask;
        uint result = positiveNumber;

        //exchanging bits
        for (int i = 3; i <= 5; i++)
        {
            //getting the bit at position i (first iteration 3 , second iteration 4 etc.)
            //and the bit at position 21 + i (first iteration 21+3=24, second iteration 25 etc.)
            //saving the bit at position 3 in firstBit and the bit in position 4 at secondBit
            int firstBit = (result >> i) % 2 != 0 ? 1 : 0;
            int secondBit = (result >> (21 + i)) % 2 != 0 ? 1 : 0;
            
            //checking the value of the secondBit(the bit at position 24) if it's 0 changing the third bit to 0
            //if it's 1 changing the third bit to 1
            if (secondBit == 0)
            {
                mask = ~(1u << i);     
                result = result & mask;       
            }
            else if (secondBit == 1)
            {
                mask = 1u << i;
                result = result | mask;                
            }

            //checking the value of the firstBit(the bit at position 3) if it's 0 changing the bit at position 24 to 0
            //if it's 1 changing to 1
            if (firstBit == 0)
            {
                mask = ~(1u << (21 + i));
                result = result & mask;
            }
            else if (firstBit == 1)
            {
                mask = 1u << (21 + i);
                result = result | mask;                
            }
        }

        //printing the new number
        Console.WriteLine("the new number is: {0} ({1})", Convert.ToString(result, 2).PadLeft(32, '0'),result);
    }
}

