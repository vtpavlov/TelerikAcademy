/*
 * Write a program that reads the coefficients a, b and c 
 * of a quadratic equation ax*x+bx+c=0 and solves it (prints its real roots).
*/

using System;
using System.Globalization;
using System.Threading;

class QuadraticEquation
{
    static void Main()
    {
        //changing the culture for the console
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        //Request for a
        Console.Write("Please enter coefficent a: ");
        double a = double.Parse(Console.ReadLine());

        //Request for b
        Console.Write("Please enter coefficent b: ");
        double b = double.Parse(Console.ReadLine());

        //Request for c
        Console.Write("Please enter coefficent c: ");
        double c = double.Parse(Console.ReadLine());

        //calculating the descriminant 
        double descriminant = b * b - 4 * a * c;

        //calculating the roots
        string result = descriminant < 0 ? "There are no real roots!"
            : "The first root is: " + ((-b + Math.Sqrt(descriminant)) / (2 * a)) + " and the second is: "
            + ((-b - Math.Sqrt(descriminant)) / (2 * a));

        //printing the result
        Console.WriteLine(result);
    }
}

