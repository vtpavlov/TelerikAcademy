/*
 * Declare  two integer variables and assign them 
 * with 5 and 10 and after that exchange their values.
*/

using System;

class IntegerVariables
{
    static void Main()
    {
        int variableOne = 5;   //declaring the first variable
        int variableTwo = 10;  //declaring the second variable
        int tempVariable;      //declaring the temporary variable

        //Exchanging values
        tempVariable = variableOne;
        variableOne = variableTwo;
        variableTwo = tempVariable;

        //Printing the values of the variables
        Console.WriteLine("variableOne = {0}, variableTwo = {1}", variableOne, variableTwo);
    }
}

