/*
 * Declare two string variables and assign them with “Hello” and “World”. 
 * Declare an object variable and assign it with the concatenation of 
 * the first two variables (mind adding an interval). Declare a third 
 * string variable and initialize it with the value of the object 
 * variable (you should perform type casting).
*/

using System;

class UsingOfStrings
{
    static void Main()
    {
        string helloStr = "Hello"; //First string variable with value "Hello" 
        string worldStr = "World"; //Second string variable with value "World"
        object concatOfStr = helloStr + " " + worldStr + "!"; //object variable with value the concatenation of the string variables
        //string result = concatOfStr.ToString();  - one way to cast object to string
        string result = (string)concatOfStr; // another way to cast object to string
        Console.WriteLine(result); // printing the result of the concatenation
    }
}

