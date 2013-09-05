/*
 * Write a program that extracts from a given text all sentences containing given word.
*/


using System;
using System.Text.RegularExpressions;

class ContainingInSentence
{
    static void Main()
    {
        string text = "We are living in a yellow submarine. We don't have anything else. " 
            + "Inside the submarine is very tight. So we are drinking all the day."
            + " We will move out of it 5 in days.";
        string word = "in";
        string regex = "[a-zA-Z0-9'\\s]+\\b" + word + "\\b[a-zA-Z0-9'\\s]+(\\.|\\!|\\?)";
        foreach (var match in Regex.Matches(text, regex, RegexOptions.IgnoreCase))
        {
            Console.WriteLine(match.ToString());    
        }        
    }
}
