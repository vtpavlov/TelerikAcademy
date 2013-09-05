/*
 * You are given a sequence of positive integer values written into a string, 
 * separated by spaces. Write a function that reads these values 
 * from given string and calculates their sum. 
 * Example: string = "43 68 9 23 318"  result = 461
*/


using System;

class StringOfIntegersSum
{
    static void Main()
    {
        Console.Write("Enter a string of integers separeted with space: ");
        string numbers = Console.ReadLine();
        string[] numbersSeparated = numbers.Split(new char[1] {' '}, StringSplitOptions.RemoveEmptyEntries);
        int sum = 0;
        foreach (var number in numbersSeparated)
        {
            sum += int.Parse(number);
        }
        Console.WriteLine("The sum of the numbers is: " + sum);
    }
}