/*
 * Write a program to check if in a given expression the brackets are put correctly.
*/


using System;
using System.Collections;

class BracketsInExpression
{
    static void Main()
    {
        Console.Write("Please enter an expression: ");
        string expression = Console.ReadLine();

        int brackets = 0;
        for (int i = 0; i < expression.Length; i++)
        {
            if (expression[i] == '(')
	        {
                brackets++;
	        }
            if (expression[i] == ')')
            {
                brackets--;
            }
        }
        if (brackets < 0)
        {
            Console.WriteLine("Wrong expression!");
        }
        else
        {
            Console.WriteLine("Correct Expression!");
        }
    }
}