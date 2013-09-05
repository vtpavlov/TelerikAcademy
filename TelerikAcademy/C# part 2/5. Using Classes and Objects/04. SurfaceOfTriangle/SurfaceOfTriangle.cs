/*
 * Write methods that calculate the surface of a triangle by given:
 * Side and an altitude to it; Three sides; 
 * Two sides and an angle between them. Use System.Math.
*/

using System;

class SurfaceOfTriangle
{
    static double TriangleSurfaceSideAlt(double side, double altitude)
    {
        return 0.5 * side * altitude;
    }

    static double TriangleSurfaceThreeSides(double firstSide, double secondSide, double thirdSide)
    {
        double halfPerimeter = (firstSide + secondSide + thirdSide) / 2;
        double surface = Math.Sqrt(halfPerimeter * (halfPerimeter - firstSide)
            * (halfPerimeter - secondSide) * (halfPerimeter - thirdSide));
        return surface;
    }

    static double TriangleSurfaceSidesAndAngle(double firstSide, double secondSide, double angle)
    {
        return 0.5 * firstSide * secondSide * Math.Sin(90);
    }

    static void Main()
    {
        double firstSide = 3.0;
        double secondSide = 4.0;
        double thirdSide = 5.0;
        double angle = 50.0;
        double altitude = 1.65;

        Console.WriteLine("Surface of triangle by side and altitude: " + TriangleSurfaceSideAlt(thirdSide, altitude));
        Console.WriteLine("Surface of triangle by three sides: " + TriangleSurfaceThreeSides(firstSide, secondSide, thirdSide));
        Console.WriteLine("Surface of triangle by two sides and angle: " + TriangleSurfaceSidesAndAngle(firstSide, secondSide, angle));
    }
}