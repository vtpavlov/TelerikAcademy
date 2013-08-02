/*
 * Write a program that shows the sign (+ or -) of the product 
 * of three real numbers without calculating it. Use a sequence of if statements.
*/

using System;
using System.Threading;
using System.Globalization;

class SignOfProduct
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

        //sequence of if statements checking the sign of the product
        if (numberOne == 0 || numberTwo == 0 || numberThree == 0)
        {
            Console.WriteLine("The product of the numbers is 0");
        }
        else if ((numberOne < 0 && numberTwo > 0 && numberThree > 0)
            || (numberOne > 0 && numberTwo < 0 && numberThree > 0)
            || (numberOne > 0 && numberTwo > 0 && numberThree < 0)
            || (numberOne < 0 && numberTwo < 0 && numberThree < 0))
        {
            Console.WriteLine("The product is < 0 and it's sign is \"-\"");
        }
        else
        {
            Console.WriteLine("The product is > 0 and it's sign is \"+\"");
        }
    }
}