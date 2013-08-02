/*
 * Write an expression that calculates trapezoid's area by given sides a and b and height h.
*/

using System;

class TrapezoidArea
{
    static void Main()
    {
        //Getting string input for side a and converting it to double
        Console.Write("Please enter side A of trapezoid: ");
        double a = double.Parse(Console.ReadLine());

        //Getting string input for side b and converting it to double
        Console.Write("Please enter side B of trapezoid: ");
        double b = double.Parse(Console.ReadLine());

        //Getting string input for height and converting it to double
        Console.Write("Please enter height of trapezoid: ");
        double height = double.Parse(Console.ReadLine());

        //expression calculating the area
        double area = ((a + b) / 2) * height;

        //printing the result
        Console.WriteLine("The area of the trapezoid is: " + area);
    }
}

