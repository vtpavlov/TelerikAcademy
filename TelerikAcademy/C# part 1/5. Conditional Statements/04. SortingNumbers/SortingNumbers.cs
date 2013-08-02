/*
 * Sort 3 real values in descending order using nested if statements.
*/

using System;
using System.Threading;
using System.Globalization;

class SortingNumbers
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

        //sequence of if statements to sort 3 real numbers
        if (numberOne > numberTwo)
        {
            if (numberThree > numberOne)
            {
                Console.WriteLine("Sorted numbers: {0} {1} {2}.", numberThree, numberOne, numberTwo);
            }
            else if (numberThree > numberTwo)
            {
                Console.WriteLine("Sorted numbers: {0} {1} {2}.", numberOne, numberThree, numberTwo);
            }
            else
            {
                Console.WriteLine("Sorted numbers: {0} {1} {2}.", numberOne, numberTwo, numberThree);
            }
        }
        else if (numberTwo > numberThree)
        {
            if (numberThree > numberOne)
            {
                Console.WriteLine("Sorted numbers: {0} {1} {2}.", numberTwo, numberThree, numberOne);
            }
            else
            {
                Console.WriteLine("Sorted numbers: {0} {1} {2}.", numberTwo, numberOne, numberThree);
            }
        }
        else
        {
            Console.WriteLine("Sorted numbers: {0} {1} {2}.", numberThree, numberTwo, numberOne);
        }
    }
}

