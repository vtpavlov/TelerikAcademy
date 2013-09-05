/*
 * Write a program that reverses the words in given sentence.
*/


using System;
using System.Collections;
using System.Text;
using System.Text.RegularExpressions;

class ReversingWords
{
    static void Main()
    {
        string sentence = "C# is not C++, not PHP and not Delphi!";
        string regexWord = "[a-zA-Z0-9#+-]+";
        string regexSymbols = "(\\.|\\!|\\?|\\,)";
        string combinedRegex = "([a-zA-Z0-9#+-]+)|(\\.|\\!|\\?|\\,)";
        MatchCollection words = Regex.Matches(sentence, regexWord, RegexOptions.IgnoreCase);
        Stack inputWords = new Stack();
        foreach (var match in words)
        {
            inputWords.Push(match);
        }
        MatchCollection symbols = Regex.Matches(sentence, regexSymbols, RegexOptions.IgnoreCase);
        Queue inputSymbols = new Queue();
        foreach (var match in symbols)
        {
            inputSymbols.Enqueue(match);
        }

        string[] splittedSentece = Regex.Split(sentence, combinedRegex);
        StringBuilder outputSentence = new StringBuilder();
        foreach (var substring in splittedSentece)
        {
            if (Regex.IsMatch(substring,regexWord))
            {
                outputSentence.Append(inputWords.Pop() + " ");
            }
            else if (Regex.IsMatch(substring, regexSymbols))
            {
                outputSentence.Append(inputSymbols.Dequeue() + " ");
            }
        }

        Console.WriteLine(outputSentence.ToString());
    }
}
