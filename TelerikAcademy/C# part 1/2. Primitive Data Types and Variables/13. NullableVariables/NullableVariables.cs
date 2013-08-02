/*
 * Create a program that assigns null values to 
 * an integer and to double variables. Try to 
 * print them on the console, try to add 
 * some values or the null literal to 
 * them and see the result.
*/

using System;

class NullableVariables
{
    static void Main()
    {
        //assigning null to integer and double variable
        int? intVariable = null;
        double? doubleVariable = null;
        //Printing the variables
        Console.WriteLine("integer variable = " + intVariable);
        Console.WriteLine("double variable = " + doubleVariable);
        //Adding values to the variables
        intVariable = intVariable + 5;
        doubleVariable = doubleVariable + 10.0;
        //Printing the variables again
        Console.WriteLine("integer variable after adding 5 = " + intVariable);
        Console.WriteLine("double variable after adding 10.0 = " + doubleVariable);
        //Adding null to variables
        intVariable = intVariable + null;
        doubleVariable = doubleVariable + null;
        //Printing the variables again
        Console.WriteLine("integer variable after adding null = " + intVariable);
        Console.WriteLine("double variable after adding null = " + doubleVariable);
    }
}

