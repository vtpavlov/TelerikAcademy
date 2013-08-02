/*
 * Write an expression that calculates rectangle’s area by given width and height.
*/

using System;

class RectangleArea
{
    static void Main()
    {
        //Getting string input for height and converting it to double
        Console.Write("Please enter height for rectangle: ");
        double height = double.Parse(Console.ReadLine());

        //Getting string input for width and converting it to double
        Console.Write("Please enter width for rectangle: ");
        double width = double.Parse(Console.ReadLine());

        //calculating the Area
        double area = width * height;

        //printing the result
        Console.WriteLine("The area of a rectangle with height = {0} and width = {1} is {2}", height, width, area);
    }
}
