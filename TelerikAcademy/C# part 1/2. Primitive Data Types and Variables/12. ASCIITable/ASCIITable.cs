/*
 * Find online more information about ASCII 
 * (American Standard Code for Information Interchange) 
 * and write a program that prints the entire 
 * ASCII table of characters on the console.
*/

using System;

class ASCIITable
{
    static void Main()
    {
        for (int count = 0; count <= 127; count++)
        {
            Console.WriteLine("{0}. {1}", count, (char)count); //Printing the symbol coresponding to "count" in ASCII table
        }
    }
}
