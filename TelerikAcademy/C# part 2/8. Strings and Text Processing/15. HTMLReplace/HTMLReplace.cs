/*
 * Write a program that replaces in a HTML document given as 
 * string all the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL]. 
*/

using System;
using System.Text.RegularExpressions;

class HTMLReplace
{
    static void Main()
    {
        string htmlText = "<p>Please visit <a href=\"http://academy.telerik. com\">our site</a> to choose a training course. "
            + "Also visit <a href=\"www.devbg.org\">our forum</a> to discuss the courses.</p>";
        string regex = "<a href\\s*=\\s*\"(?<insideHref>.*?)\".*?>(?<insideTag>.*?)</a>";
        Console.WriteLine(Regex.Replace(htmlText,regex,g => "[URL=" + g.Groups["insideHref"] + "]" 
            + g.Groups["insideTag"] + "[/URL]"));
    }
}