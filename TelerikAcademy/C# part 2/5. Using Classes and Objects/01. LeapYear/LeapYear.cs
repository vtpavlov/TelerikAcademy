/*
 * Write a program that reads a year from the console and checks whether it is a leap. Use DateTime.
*/


using System;

class LeapYear
{
    static void Main()
    {
        Console.Write("Please enter an year: ");
        Console.WriteLine("The year is leap: " + DateTime.IsLeapYear(int.Parse(Console.ReadLine())));
    }
}
