/*
 * Which of the following values can be assigned to a variable
 * of type float and which to a variable of type double: 
 * 34.567839023, 12.345, 8923.1234857, 3456.091?
*/

using System;

class FloatAndDouble
{
    static void Main()
    {
        double numberOne = 34.567839023;    // if we declare it as float it will round the number
        float numberTwo = 12.345f;          // the number is short enough to declare it as float
        double numberThree = 8923.1234857;  // too large number for float
        float numberFour = 3456.091f;       // short enough for float

        //Printing the numbers to see that there is no rounding
        Console.WriteLine(numberOne + " " + numberTwo + " " + numberThree + " " + numberFour);
    }
}

