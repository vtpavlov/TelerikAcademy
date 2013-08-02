/*
 * Write a program that can solve these tasks:
 *  Reverses the digits of a number
 *  Calculates the average of a sequence of integers
 *  Solves a linear equation a * x + b = 0
 * 
 * Create appropriate methods.
 * Provide a simple text-based menu for the user to choose which task to solve.
 *
 * Validate the input data:
 *  The decimal number should be non-negative
 *  The sequence should not be empty
 *  a should not be equal to 0
*/


using System;
using System.Text;

class TaskSolver
{
    static void ReverseDigit(ref int number)
    {
        //making number as string and splitting it to char symbols
        char[] digits = number.ToString().ToCharArray();

        //string builder to append the chars from last to the first
        StringBuilder result = new StringBuilder();

        for (int i = digits.Length - 1; i >= 0; i--)
        {
            result.Append(digits[i]);
        }

        //saving the new number as integer
        number = int.Parse(result.ToString());
    }

    static double Average(int[] integers)
    {
        int sum = 0;

        for (int i = 0; i < integers.Length; i++)
        {
            sum += integers[i];
        }

        return (double)sum / integers.Length;
    }

    static double SolvingEquation(double a, double b)
    {
        return -b / a;
    }

    static void Main()
    {
        Console.WriteLine("Chose which task to solve:");
        Console.WriteLine("1. Reverse digits - type 1");
        Console.WriteLine("2. Average of Integers - type 2");
        Console.WriteLine("3. Solving Linear Equation - type 3");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.Write("Please enter an integer: ");
                int integer = int.Parse(Console.ReadLine());
                if (integer < 0)
                {
                    Console.WriteLine("The integer is negative!");
                }
                else
                {
                    ReverseDigit(ref integer);
                    Console.WriteLine("The reversed digit is: " + integer);
                }
                break;
            case 2:
                Console.Write("Enter number of integers: ");
                int count = int.Parse(Console.ReadLine());
                if (count <= 0)
                {
                    Console.WriteLine("Wrong input");
                }
                else
                {
                    int[] integers = new int[count];
                    for (int i = 0; i < count; i++)
                    {
                        Console.Write("Please enter number {0}: ", i);
                        integers[i] = int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine("The average is: " + Average(integers));
                }
                break;

            case 3:
                Console.Write("Please enter coefficent a: ");
                double a = double.Parse(Console.ReadLine());
                if (a == 0)
                {
                    Console.WriteLine("Wrong input!");
                }
                else
                {
                    Console.Write("Please enter coefficent b: ");
                    double b = double.Parse(Console.ReadLine());
                    Console.WriteLine("The result is: " + SolvingEquation(a, b));
                }
                break;
            default:
                break;
        }
    }
}