/*
 * You are given a text. Write a program that changes the text in all regions 
 * surrounded by the tags <upcase> and </upcase> to uppercase. The tags cannot be nested. 
*/

using System;
using System.Text.RegularExpressions;

class Upcasing
{
    static void Main()
    {
        Console.Write("Please enter a text: ");
        string text = Console.ReadLine();
        string regex = "<upcase>(?<insideUpcase>(.|\\s)*?)</upcase>";
        Console.WriteLine();
        Console.WriteLine(Regex.Replace(text, regex, g => g.Groups["insideUpcase"].Value.ToUpper()));
    }
}