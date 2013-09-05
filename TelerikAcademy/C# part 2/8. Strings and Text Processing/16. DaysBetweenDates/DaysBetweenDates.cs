/*
 * Write a program that reads two dates in the format: day.month.year and calculates the number of days between them. 
*/

using System;

class DaysBetweenDates
{
    static void Main()
    {
        Console.Write("Please enter date in format day.month.year: ");
        string firstDateString = Console.ReadLine();
        Console.Write("Please enter second date in format day.month.year: ");
        string secondDateString = Console.ReadLine();
        string[] firstSplittedDate = firstDateString.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
        DateTime firstDate = new DateTime(int.Parse(firstSplittedDate[2])
            , int.Parse(firstSplittedDate[1]), int.Parse(firstSplittedDate[0]));
        string[] secondSplittedDate = secondDateString.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
        DateTime secondDate = new DateTime(int.Parse(secondSplittedDate[2])
            , int.Parse(secondSplittedDate[1]), int.Parse(secondSplittedDate[0]));
        if (firstDate > secondDate)
        {
            Console.WriteLine((firstDate - secondDate).Days);
        }
        else
        {
            Console.WriteLine((secondDate - firstDate).Days);
        }
    }
}
