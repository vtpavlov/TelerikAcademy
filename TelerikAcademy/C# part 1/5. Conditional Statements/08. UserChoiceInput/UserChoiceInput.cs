/*
 * Write a program that, depending on the user's choice 
 * inputs int, double or string variable. If the variable 
 * is integer or double, increases it with 1. If the variable 
 * is string, appends "*" at its end. The program must show 
 * the value of that variable as a console output. 
 * Use switch statement.
*/

using System;
using System.Globalization;
using System.Threading;

class UserChoiceInput
{
    static void Main()
    {
        //changing regional settings to Invariant
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        //geting user's choice
        Console.WriteLine("Please enter 1 for int variable.");
        Console.WriteLine("Please enter 2 for double variable.");
        Console.WriteLine("Please enter 3 for string variable.");
        int choice = int.Parse(Console.ReadLine());

        //switch statement that checks If the variable is integer or double and increases it with 1. If the variable 
        //is string, appends "*" at its end.
        
        switch (choice)
        {
            case 1:
                Console.Write("Please enter valid Integer: ");
                int intVariable = int.Parse(Console.ReadLine());
                intVariable++;
                Console.WriteLine("The new value is: " + intVariable);
                break;
            case 2:
                Console.Write("Please enter valid Double: ");
                double doubleVariable = double.Parse(Console.ReadLine());
                doubleVariable++;
                Console.WriteLine("The new value is: " + doubleVariable);
                break;
            case 3:
                Console.Write("Please enter some string: ");
                string stringVariable = Console.ReadLine();
                stringVariable = stringVariable + "*";
                Console.WriteLine("The new value is: " + stringVariable);
                break;
            default:
                Console.WriteLine("Wrong choice!");
                break;
        }
    }
}

