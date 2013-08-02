/*
 * Declare a character variable and assign it with the 
 * symbol that has Unicode code 72. Hint: first use the 
 * Windows Calculator to find the hexadecimal representation of 72.
*/

using System;

class CharVariable
{
    static void Main()
    {
        char symbol = '\u0048'; //initialize variable symbol with value
        Console.WriteLine("The symbol with Unicode code 72 is : " + symbol);  //Printing the symbol
    }
}

