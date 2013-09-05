/*
 * Write a program that reads a date and time given in the format: 
 * day.month.year hour:minute:second 
 * and prints the date and time after 6 hours and 30 minutes (in the same format) 
 * along with the day of week in Bulgarian.
*/


using System;

class TimeAfterSixHoursAndHalf
{
    static void Main()
    {
        Console.Write("Please enter date in format day.month.year hour:minute:second: ");
        string dateString = Console.ReadLine();
        
        string[] splittedDate = dateString.Split(new char[] { '.', ' ', ':' }, StringSplitOptions.RemoveEmptyEntries);
        DateTime date = new DateTime(int.Parse(splittedDate[2]), int.Parse(splittedDate[1]), int.Parse(splittedDate[0])
            , int.Parse(splittedDate[3]), int.Parse(splittedDate[4]), int.Parse(splittedDate[5]));

        date = date.AddHours(6);
        date = date.AddMinutes(30);

        Console.WriteLine("Date after 6:30 hours = {0}.{1}.{2} {3}:{4}:{5}", date.Day, date.Month, date.Year
            , date.Hour, date.Minute, date.Second);
        Console.WriteLine("Day of week: " + date.DayOfWeek);
    }
}
