/*
 * Write a program that reads the radius r 
 * of a circle and prints its perimeter and area.
*/

using System;

class CircleAreaAndPerimeter
{
    static void Main()
    {
        //Request for radius input
        Console.Write("Please enter the radius of a circle: ");
        double radius;
        bool validRadius = double.TryParse(Console.ReadLine(), out radius);

        //validating the radius and printing the area and perimeter
        string result = validRadius ? "The perimeter of the circle is: " + 
            (2 * Math.PI * radius) + " and the area: " + (Math.PI * radius * radius) : "Invalid radius";
        Console.WriteLine(result);
    }
}

