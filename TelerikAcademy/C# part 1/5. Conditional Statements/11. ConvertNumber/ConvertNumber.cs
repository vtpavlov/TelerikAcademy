/*
 * Write a program that converts a number in the range [0...999] 
 * to a text corresponding to its English pronunciation. 
 * Examples:
	0 -> "Zero"
	273 -> "Two hundred seventy three"
	400 -> "Four hundred"
	501 -> "Five hundred and one"
	711 -> "Seven hundred and eleven"
*/

using System;

class ConvertNumber
{
    static void Main()
    {
        //getting the number from console
        Console.WriteLine("Please enter a number between 1 and 999.");
        int number = int.Parse(Console.ReadLine());

        //arrays with strings
        string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        string[] tens = { "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };
        string[] betweenTenAndTwenty = {"ten", "eleven", "twelve", "thirteen", "fourteen"
                                           , "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
        string hundred = "hundred";

        //sequence of if statements to find the string representing the number
        if (number <= 9)
        {
            Console.WriteLine(digits[number]);
        }
        else if (number <= 19)
        {
            Console.WriteLine(tens[number - 10]);
        }
        else if (number <= 99)
        {
            if (number % 10 == 0)
            {
                Console.WriteLine(tens[(number / 10) - 2]);
            }
            else
            {
                Console.WriteLine(tens[(number / 10) - 2] + " " + digits[number % 10]);
            }
        }
        else if (number <= 999)
        {
            if (number % 100 == 0)
            {
                Console.WriteLine(digits[number / 100] + " " + hundred);
            }
            else if (number % 100 <= 9)
            {
                Console.WriteLine(digits[number / 100] + " " + hundred + " and " + digits[number % 100]);
            }
            else if (number % 100 <= 19)
            {
                Console.WriteLine(digits[number / 100] + " " + hundred + " and " + betweenTenAndTwenty[(number % 100) - 10]);
            }
            else
            {
                if (number % 10 == 0)
                {
                    Console.WriteLine(digits[number / 100] + " " + hundred + " and " + tens[((number % 100) / 10) - 2]);
                }
                else
                {
                    Console.WriteLine(digits[number / 100] + " " + hundred + " " 
                        + tens[((number % 100) / 10) - 2] + " " + digits[number % 10]);
                }
            }
        }
        else
        {
            Console.WriteLine("Wrong number!");
        }
    }
}

