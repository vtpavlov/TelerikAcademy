/*
 * Write a method that asks the user for his name 
 * and prints “Hello, <name>” (for example, “Hello, Peter!”). 
 * Write a program to test this method.
*/


using System;

class MethodAskingForName
{
    //method asking for user's name and printing hello, <name>
    static void AskingForName()
    {
        string name;

        //asking for the user's name
        Console.Write("Please enter your name: ");
        name = Console.ReadLine();

        //printing Hello, <name>!
        Console.WriteLine("Hello, {0}!", name);
    }

    static void Main()
    {
        AskingForName();
    }
}