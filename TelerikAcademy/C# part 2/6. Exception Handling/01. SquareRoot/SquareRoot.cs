/*
 * Write a program that reads an integer number and calculates and prints its square root. 
 * If the number is invalid or negative, print "Invalid number". 
 * In all cases finally print "Good bye". Use try-catch-finally.
*/


using System;

class SquareRoot
{
    static void Main()
    {
        Console.Write("Please enter a number: ");
        string number = Console.ReadLine();

        try
        {
            int integer = ReadNumber(number);
            double result = CalculateSquareRoot(integer);
            Console.WriteLine("Square root of the number {0} is {1}.", integer, result);
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid number!");
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("Invalid number!");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Invalid number!");
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("Invalid number!");
        }
        finally
        {
            Console.WriteLine("Good bye!");
        }
        
    }

    private static double CalculateSquareRoot(int integer)
    {
        if (integer < 0)
        {
            throw new ArgumentOutOfRangeException("The number is negative!");
        }
        double squareRoot = Math.Sqrt(integer);
        return squareRoot;
    }

    private static int ReadNumber(string number)
    {
        int integer = int.Parse(number);
        return integer;
    }
}