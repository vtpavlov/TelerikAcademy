/*
 * Write a method that calculates the number of workdays between 
 * today and given date, passed as parameter. 
 * Consider that workdays are all days from 
 * Monday to Friday except a fixed list of public 
 * holidays specified preliminary as array.
*/


using System;

class NumberOfWorkdays
{
    

    static void Main()
    {
        DateTime date = new DateTime(2013, 9, 8);
        date.AddDays(1);
        Console.WriteLine("Work days between today and {0}: Workdays: {1}", date, CalculateWorkdays(date));
    }

    private static int CalculateWorkdays(DateTime date)
    {
        //Array holding the holidays
        DateTime[] holidays = new DateTime[2];
        holidays[0] = new DateTime(2013, 8, 9); 
        holidays[1] = new DateTime(2013, 8, 10);
        
        //getting the current date
        DateTime currentDate = DateTime.Now;
        int numberOfDays = 0;
        bool isHoliday = false;

        //while current date != date
        while (currentDate.Year != date.Year || currentDate.Month != date.Month || currentDate.Day != date.Day)
        {
            //checking if current date = holiday
            foreach (var holiday in holidays)
            {
                if (currentDate.Year == holiday.Year && currentDate.Month == holiday.Month && currentDate.Day == holiday.Day)
                {
                    isHoliday = true;
                }
            }

            //if current date != Saturday and Sunday and is not holiday number of days ++
            if (!currentDate.DayOfWeek.Equals(DayOfWeek.Saturday)
                && !currentDate.DayOfWeek.Equals(DayOfWeek.Sunday) && isHoliday == false)
            {
                numberOfDays++;              
            }

            //Adding one day to current date
            currentDate = currentDate.AddDays(1);
            isHoliday = false;
        }
        return numberOfDays;
    }
}