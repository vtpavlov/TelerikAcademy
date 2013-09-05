/*
 * Write a program for extracting all email addresses from given text. 
 * All substrings that match the format <identifier>@<host>…<domain> should be recognized as emails.
*/


using System;
using System.Text.RegularExpressions;

class EmailExtraction
{
    static void Main()
    {
        string text = "Hello this is an email: pesho@abv.bg and this is another email: stamat@gmail.com and this is some fail email:"
        + " ehoo@abv....bg and this is .. i don't know what.";
        string regex = "(?<identifier>\\w+?)@(?<host>\\w+?)(\\.+?)+\\w+";
        MatchCollection matches = Regex.Matches(text, regex, RegexOptions.IgnoreCase);
        foreach (var match in matches)
        {
            Console.WriteLine(match.ToString());
        }
    }
}
