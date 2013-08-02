/*
 * Write an if statement that examines two integer variables 
 * and exchanges their values if the first one is greater than the second one.
*/

using System;

class IntegerExchange
{
    static void Main()
    {
        //getting integer number from console
        Console.Write("Please enter valid Integer: ");
        int integerOne = int.Parse(Console.ReadLine());

        //getting second integer number from console
        Console.Write("Please enter second valid Integer: ");
        int integerTwo = int.Parse(Console.ReadLine());

        //printing the numbers
        Console.WriteLine("The numbers that you entered are: {0} and {1}", integerOne, integerTwo);

        //if statement that exchange the numbers if the first one is greater
        if (integerOne > integerTwo)
        {
            int tempVariable = integerOne;
            integerOne = integerTwo;
            integerTwo = tempVariable;

            //Printing the result
            Console.WriteLine("The numbers after an exchange are: {0} and {1}", integerOne, integerTwo);
        }
    }
}

