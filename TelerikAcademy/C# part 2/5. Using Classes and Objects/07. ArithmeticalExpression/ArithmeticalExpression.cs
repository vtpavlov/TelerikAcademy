/*
 * Write a program that calculates the value of given arithmetical expression. 
 * The expression can contain the following elements only:
 *      Real numbers, e.g. 5, 18.33, 3.14159, 12.6
 *      Arithmetic operators: +, -, *, / (standard priorities)
 *      Mathematical functions: ln(x), sqrt(x), pow(x,y)
 *      Brackets (for changing the default priorities)
 * Examples:
 *      (3+5.3) * 2.7 - ln(22) / pow(2.2, -1.7)  ~ 10.6
 *      pow(2, 3.14) * (3 - (3 * sqrt(2) - 3.2) + 1.5*0.3)  ~ 21.22
*/


using System;
using System.Collections;
using System.Text;

class ArithmeticalExpression
{
    private static Queue ShuntingYardAlgorithm(string[] expression)
    {
        //output Queue
        Queue outputQueue = new Queue();
        
        //Stack
        Stack stack = new Stack();

        //While there are tokens to be read:
        for (int i = 0; i < expression.Length; i++)
        {
            //Read a token.
            string token = expression[i];

            //If the token is a number, then add it to the output queue.
            double number;
            if (double.TryParse(token.ToString(),out number))
            {
                outputQueue.Enqueue(token);
            }

            //If the token is a function token, then push it onto the stack.
            if (token == "ln" || token == "sqrt" || token == "pow")
            {
                stack.Push(token);
            }

            //If the token is a function argument separator (e.g., a comma):
            if (token == ",")
            {
                if (stack.Count != 0)
                {
                    //Until the token at the top of the stack is a left parenthesis, pop operators off the stack onto the output queue. 
                    while ((string)stack.Peek() != "(")
                    {
                        outputQueue.Enqueue(stack.Pop());
                        //If no left parentheses are encountered, either the separator was misplaced or parentheses were mismatched.
                        if (stack.Count == 0)
                        {
                            Console.WriteLine("Your expression is not correct!");
                            break;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Your expression is not correct!");
                    break;
                }
            }

            //If the token is an operator, o1, then:
                //while there is an operator token, o2, at the top of the stack, and
                    //either o1 is left-associative and its precedence is equal to that of o2,
                    //or o1 has precedence less than that of o2,
                //pop o2 off the stack, onto the output queue;
            //push o1 onto the stack.
            switch (token)
            {
                case "*":
                    stack.Push(token);
                    break;
                case "/":                    
                    stack.Push(token);
                    break;
                case "+":
                    if (stack.Count != 0)
                    {
                        while ((string)stack.Peek() == "/" || (string)stack.Peek() == "*" || (string)stack.Peek() == "-")
                        {
                            outputQueue.Enqueue(stack.Pop());
                            if (stack.Count == 0)
                            {
                                break;
                            }
                        }    
                    }                    
                    stack.Push(token);
                    break;
                case "-":
                    if (stack.Count != 0)
                    {
                        while ((string)stack.Peek() == "/" || (string)stack.Peek() == "+" || (string)stack.Peek() == "*")
                        {
                            outputQueue.Enqueue(stack.Pop());
                            if (stack.Count == 0)
                            {
                                break;
                            }
                        }
                    }
                    stack.Push(token);
                    break;
            }

            //If the token is a left parenthesis, then push it onto the stack.
            if (token == "(")
            {
                stack.Push(token);
            }

            //If the token is a right parenthesis:
            if (token == ")")
            {
                //Until the token at the top of the stack is a left parenthesis, pop operators off the stack onto the output queue.
                if (stack.Count != 0)
                {
                    while ((string)stack.Peek() != "(")
                    {
                        outputQueue.Enqueue(stack.Pop());
                        //If the stack runs out without finding a left parenthesis, then there are mismatched parentheses.
                        if (stack.Count == 0)
                        {
                            Console.WriteLine("Your expression is not correct!");
                            break;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Your expression is not correct!");
                    break;
                }

                //Pop the left parenthesis from the stack, but not onto the output queue.
                if (stack.Count != 0)
                {
                    if ((string)stack.Peek() == "(")
                    {
                        stack.Pop();
                    }
                }
                else
                {
                    Console.WriteLine("Your expression is not correct!");
                    break;
                }

                //If the token at the top of the stack is a function token, pop it onto the output queue.
                if (stack.Count != 0)
                {
                    if ((string)stack.Peek() == "ln" || (string)stack.Peek() == "sqrt" || (string)stack.Peek() == "pow")
                    {
                        outputQueue.Enqueue(stack.Pop());
                    }
                }
            }
        }
        //When there are no more tokens to read:

        //While there are still operator tokens in the stack:
        while (stack.Count != 0)
        {
            //If the operator token on the top of the stack is a parenthesis, then there are mismatched parentheses.
            if ((string)stack.Peek() == "(" || (string)stack.Peek() == ")")
            {
                Console.WriteLine("Your expression is not correct!");
            }

            //Pop the operator onto the output queue.
            outputQueue.Enqueue(stack.Pop());
        }
       
        return outputQueue;
    }

    private static double ReversePolishNotation(Queue inputQueue)
    {
        //stack
        Stack stack = new Stack();

        //While there are input tokens left 
        while (inputQueue.Count != 0)
        {
            //Read the next token from input.
            string token = (string)inputQueue.Dequeue();

            //If the token is a value
            double number;
            if (double.TryParse(token.ToString(), out number))
            {
                //Push it onto the stack.
                stack.Push(token.ToString());
            }
            else //Otherwise, the token is an operator (operator here includes both operators, and functions).
            {
                //Assumming that our previous algorithm works correct we don't have checks here
                switch (token)
                {
                    case "*":
                        double resultMul = double.Parse((string)stack.Pop()) * double.Parse((string)stack.Pop());
                        stack.Push(resultMul.ToString());
                        break;
                    case "/":
                        double a = double.Parse((string)stack.Pop());
                        double b = double.Parse((string)stack.Pop());
                        double resultDiv = b / a;
                        stack.Push(resultDiv.ToString());
                        break;
                    case "+":
                        double resultAdd = double.Parse((string)stack.Pop()) + double.Parse((string)stack.Pop());
                        stack.Push(resultAdd.ToString());
                        break;
                    case "-":
                        double firstNumM = double.Parse((string)stack.Pop());
                        double secondNumM = double.Parse((string)stack.Pop());
                        double resultMin = secondNumM - firstNumM;
                        stack.Push(resultMin.ToString());
                        break;
                    case "ln":
                        double resultLn = Math.Log(double.Parse((string)stack.Pop()));
                        stack.Push(resultLn.ToString());
                        break;
                    case "sqrt":
                        double resultSqrt = Math.Sqrt(double.Parse((string)stack.Pop()));
                        stack.Push(resultSqrt.ToString());
                        break;
                    case "pow":
                        double firstNumber = double.Parse((string)stack.Pop());
                        double secondNumber = double.Parse((string)stack.Pop());
                        double resultPow = Math.Pow(secondNumber, firstNumber);
                        stack.Push(resultPow.ToString());
                        break;
                }
            }
        }
        return double.Parse((string)stack.Pop());
    }

    //Method to Tokenize the input string
    private static string[] Tokenize(string expression)
    {
        //removing all spaces
        string[] expressionArrayWithoutSpace = expression.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        StringBuilder expressionWithoutSpace = new StringBuilder();
        foreach (var token in expressionArrayWithoutSpace)
        {
            expressionWithoutSpace.Append(token);
        }
        string exp = expressionWithoutSpace.ToString();

        //Adding spaces to particular positions
        StringBuilder expWithSpaces = new StringBuilder();
        for (int i = 0; i < exp.Length; i++)
        {
            if (exp[i] == 'l')
            {
                expWithSpaces.Append(" ");
                expWithSpaces.Append(exp[i]);
            }
            else if (exp[i] == 'n')
            {                
                expWithSpaces.Append(exp[i]);
                expWithSpaces.Append(" ");
            }

            else if (exp[i] == 's')
            {
                expWithSpaces.Append(" ");
                expWithSpaces.Append(exp[i]);
            }
            else if (exp[i] == 't')
            {
                expWithSpaces.Append(exp[i]);
                expWithSpaces.Append(" ");
            }

            else if (exp[i] == 'p')
            {
                expWithSpaces.Append(" ");
                expWithSpaces.Append(exp[i]);
            }
            else if (exp[i] == 'w')
            {
                expWithSpaces.Append(exp[i]);
                expWithSpaces.Append(" ");
            }
           
            else if (exp[i] == '(')
            {
                expWithSpaces.Append(" ");
                expWithSpaces.Append(exp[i]);
                expWithSpaces.Append(" ");
            }
            else if (exp[i] == ')')
            {
                expWithSpaces.Append(" ");
                expWithSpaces.Append(exp[i]);
                expWithSpaces.Append(" ");
            }
            else if (exp[i] == '+')
            {
                expWithSpaces.Append(" ");
                expWithSpaces.Append(exp[i]);
                expWithSpaces.Append(" ");
            }
            else if (exp[i] == '-')
            {
                if (i == 0)
                {
                    expWithSpaces.Append(exp[i]); 
                }
                else if (exp[i - 1] == '+' || exp[i - 1] == '*' || exp[i - 1] == '/'
                    || exp[i - 1] == ',' || exp[i - 1] == '(')
                {
                    expWithSpaces.Append(exp[i]);
                }
                else
                {
                    expWithSpaces.Append(" ");
                    expWithSpaces.Append(exp[i]);
                    expWithSpaces.Append(" ");
                }                
            }
            else if (exp[i] == '*')
            {
                expWithSpaces.Append(" ");
                expWithSpaces.Append(exp[i]);
                expWithSpaces.Append(" ");
            }
            else if (exp[i] == '/')
            {
                expWithSpaces.Append(" ");
                expWithSpaces.Append(exp[i]);
                expWithSpaces.Append(" ");
            }
            else if (exp[i] == ',')
            {
                expWithSpaces.Append(" ");
                expWithSpaces.Append(exp[i]);
                expWithSpaces.Append(" ");
            }
            else
            {
                expWithSpaces.Append(exp[i]);
            }
        }

        //removing all the splaces again with split and getting an array of tokens
        return expWithSpaces.ToString().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
    }

    //The program works only with number separator "."
    static void Main()
    {
        System.Globalization.CultureInfo customCulture = 
            (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
        customCulture.NumberFormat.NumberDecimalSeparator = ".";
        System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

        Console.WriteLine("Please enter an expression and use for number spearator a dot, and lower case for functions: ");      
        Console.WriteLine("Result: " + ReversePolishNotation(ShuntingYardAlgorithm(Tokenize(Console.ReadLine()))));
    }
}
