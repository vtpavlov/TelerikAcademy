/*
 * We are given integer number n, value v (v=0 or 1) and a position p. 
 * Write a sequence of operators that modifies n to hold the value v 
 * at the position p from the binary representation of n.
 * 
 * Example: n = 5 (00000101), p=3, v=1 -> 13 (00001101)
 *          n = 5 (00000101), p=2, v=0 -> 1  (00000001)
*/ 


using System;

class ExchangeBit
{
    static void Main()
    {
        //Getting string input and converting it to integer
        Console.Write("Please enter a number: ");
        int n = int.Parse(Console.ReadLine());

        //printing the number
        Console.WriteLine("the number is: {0}", Convert.ToString(n, 2).PadLeft(32, '0'));

        //Getting string input for position p and converting it to integer
        Console.Write("Please enter a position of the bit that u want to change: ");
        int p = int.Parse(Console.ReadLine());

        //Getting string input for value v and converting it to integer
        Console.Write("Please enter 1 or 0: ");
        int v = int.Parse(Console.ReadLine());

        int mask;
        int result = n;

        //expression to change the bit at position p
        if (v == 0)
        {
            mask = ~(1 << p);     //mask number
            result = n & mask;    //result number
        }
        else if (v == 1)
        {
            mask = 1 << p;       
            result = n | mask;
        }
        else
        {
            Console.WriteLine("Wrong value for bit , the number didn't change!");   
        }

        //printing the result
        Console.WriteLine("the number after the change is: {0} ({1})", Convert.ToString(result, 2).PadLeft(32, '0'), result);
    }
}
