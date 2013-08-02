/*
 * Write a program that finds the greatest of given 5 variables.
*/

using System;
using System.Globalization;
using System.Threading;

class GreatestOfFive
{
    static void Main()
    {
        //changing regional settings to Invariant
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        //getting double number from console
        Console.Write("Please enter the first number: ");
        double numberOne = double.Parse(Console.ReadLine());

        //getting second double number from console
        Console.Write("Please enter the second number: ");
        double numberTwo = double.Parse(Console.ReadLine());

        //getting third double number from console
        Console.Write("Please enter the third number: ");
        double numberThree = double.Parse(Console.ReadLine());
        
        //getting fourth double number from console
        Console.Write("Please enter the fourth number: ");
        double numberFour = double.Parse(Console.ReadLine());

        //getting fifth double number from console
        Console.Write("Please enter the fifth number: ");
        double numberFive = double.Parse(Console.ReadLine());

        //variable holding the current greatest variable
        double greatest = numberOne;

        //checking for each number if it's bigger then greatest
        if (numberTwo > greatest)
        {
            greatest = numberTwo;
        }
        
        if (numberThree > greatest)
        {
            greatest = numberThree;
        }
        
        if (numberFour > greatest)
        {
            greatest = numberFour;
        }
        
        if (numberFive > greatest)
        {
            greatest = numberFive;
        }

        //printing the result
        Console.WriteLine("The greatest number of the given 5 is: " + greatest);
    }
}

