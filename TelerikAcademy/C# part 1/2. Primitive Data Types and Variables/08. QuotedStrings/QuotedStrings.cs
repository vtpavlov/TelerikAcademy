/*
 * Declare two string variables and assign them with following value:
 * The "use" of quotations causes difficulties.
 * Do the above in two different ways: with and without using quoted strings.
 */

using System;

class QuotedStrings
{
    static void Main()
    {
        //assigning to 2 different strings "The "use" of quotations causes difficulties." in a two different ways
        string firstString = "The \"use\" of quotations causes difficulties.";
        string secondString = @"The ""use"" of quotations causes difficulties.";
        
        //Printing the strings
        Console.WriteLine("firstString without quoted strings: ");
        Console.WriteLine(firstString);
        Console.WriteLine(); // empty line for better reading
        Console.WriteLine("secondString with quoted strings: ");
        Console.WriteLine(secondString);
    }
}

