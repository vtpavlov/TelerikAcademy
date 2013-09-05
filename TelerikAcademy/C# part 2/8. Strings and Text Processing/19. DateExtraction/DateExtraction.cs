/*
 * Write a program that extracts from a given text all dates that match the format DD.MM.YYYY. 
 * Display them in the standard date format for Canada.
*/


using System;
using System.Text.RegularExpressions;

class DateExtraction
{
    static void Main()
    {
        string text = "Hello this is a date 11.12.2013 and this is another date: 10.01.2015 and this is some fail date:"
    + " 1.12.203 and this is .. i don't know what.";
        string regex = "([0-9]{2}).([0-9]{2}).([0-9]{4})";
        MatchCollection matches = Regex.Matches(text, regex, RegexOptions.IgnoreCase);
        foreach (var match in matches)
        {
            Console.WriteLine(match.ToString());
        } 
    }
}
