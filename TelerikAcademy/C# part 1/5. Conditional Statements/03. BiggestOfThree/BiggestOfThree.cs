/*
 * Write a program that finds the biggest 
 * of three integers using nested if statements.
*/

using System;

class BiggestOfThree
{
    static void Main()
    {
        //getting integer number from console
        Console.Write("Please enter valid Integer: ");
        int integerOne = int.Parse(Console.ReadLine());

        //getting second integer number from console
        Console.Write("Please enter second valid Integer: ");
        int integerTwo = int.Parse(Console.ReadLine());

        //getting third integer number from console
        Console.Write("Please enter third valid Integer: ");
        int integerThree = int.Parse(Console.ReadLine());

        //nested if statements finding the biggest integer of three
        if (integerOne > integerTwo)
        {
            if (integerThree > integerOne)
            {
                Console.WriteLine("The biggest number is {0}.", integerThree);
            }
            else
            {
                Console.WriteLine("The biggest number is {0}.", integerOne);
            }
        }
        else if (integerTwo > integerThree)
        {
            Console.WriteLine("The biggest number is {0}.", integerTwo);
        }
        else
        {
            Console.WriteLine("The biggest number is {0}.", integerThree);
        }
    }
}

