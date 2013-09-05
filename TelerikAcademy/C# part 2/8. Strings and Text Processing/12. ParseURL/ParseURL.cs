/*
 * Write a program that parses an URL address and extracts from 
 * it the [protocol], [server] and [resource] elements.
*/


using System;
using System.Text.RegularExpressions;

class ParseURL
{
    static void Main()
    {
        string url = "http://www.devbg.org/forum/index.php";
        string regex = "(.+)://(.+?)/(.+)";
        Console.WriteLine("Protocol: {0}", Regex.Match(url, regex).Groups[1]);
        Console.WriteLine("Server: {0}", Regex.Match(url, regex).Groups[2]);
        Console.WriteLine("Resource: {0}", Regex.Match(url, regex).Groups[3]);
    }
}
