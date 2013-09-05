/*
 * Write a method ReadNumber(int start, int end) that 
 * enters an integer number in given range [start…end]. 
 * If an invalid number or non-number text is entered, 
 * the method should throw an exception. 
 * Using this method write a program that enters 10 numbers:		
 * a1, a2, … a10, such that 1 < a1 < … < a10 < 100
*/


using System;

class IntegerInRange
{
    private static int ReadNumber(int start, int end)
    {
        int number = int.Parse(Console.ReadLine());
        if (number < start || number > end)
        {
            throw new ArgumentOutOfRangeException(String.Format(
                "The number is either too big or too small. Please enter a number in range [{0}, {1}].", start, end));
        }
        return number;
    }

    static void Main()
    {
        int[] tenNumbers = new int[10];
        int start = 1;
        int end = 91;
        for (int i = 0; i < 10; i++)
        {
            try
            {
                Console.Write("Please enter integer {0}: ", i);
                tenNumbers[i] = ReadNumber(start, end);
                start = tenNumbers[i] + 1;
                end = 91 + i + 1;
            }            
            catch(FormatException)
            {
                Console.WriteLine(
                    "The number is invalid! Please enter a number in range [{0}, {1}]", start, end);
                i--;
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine(
                    "The number is invalid! Please enter a number in range [{0}, {1}]", start, end);
                i--;
            }
            catch (OverflowException)
            {
                Console.WriteLine(
                    "The number is invalid! Please enter a number in range [{0}, {1}]", start, end);
                i--;
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine(
                    "The number is invalid! Please enter a number in range [{0}, {1}]", start, end);
                i--;
            }
        }

        Console.Write("The numbers you have entered are: ");
        foreach (int number in tenNumbers)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();
    }
}
