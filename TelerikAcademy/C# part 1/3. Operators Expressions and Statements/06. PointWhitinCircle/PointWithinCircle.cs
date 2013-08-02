/*
 * Write an expression that checks if given point (x,  y) is within a circle K(O, 5).
*/

using System;

class PointWithinCircle
{
    static void Main()
    {
        //Getting string input for x and converting it to double
        Console.Write("Please enter x coordinate of a point: ");
        double x = double.Parse(Console.ReadLine());

        //Getting string input for y and converting it to double
        Console.Write("Please enter y coordinate of a point: ");
        double y = double.Parse(Console.ReadLine());

        //expression checking if the point is inside the circle K((0,0) ,5)
        string result = (x * x) + (y * y) < 5*5 ? "The point is inside the circle K((0, 0), 5)" 
            : "The point is outside the circle K((0, 0), 5)";

        //printing the result
        Console.WriteLine(result);
    }
}

