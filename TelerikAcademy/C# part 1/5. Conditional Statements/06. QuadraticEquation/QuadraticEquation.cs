/*
 * Write a program that enters the coefficients a, b and c of a quadratic equation
 * a*x2 + b*x + c = 0 and calculates and prints its real roots. 
 * Note that quadratic equations may have 0, 1 or 2 real roots.
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

        //if statements to find the roots
        if (descriminant < 0)
        {
            Console.WriteLine("The equation doesn't have a real root");
        }
        else if (descriminant == 0)
        {
            Console.WriteLine("The equation have a single root: {0}", (-b / (2 * a)));
        }
        else
        {
            Console.WriteLine("The equation have two roots: {0} and {1}"
                , (-b + Math.Sqrt(descriminant)) / (2 * a), (-b - Math.Sqrt(descriminant)) / (2 * a));
        }        
    }
}