/*
 * Write a program that, for a given two integer numbers N and X, 
 * calculates the sumS = 1 + 1!/X + 2!/X^2 + … + N!/X^N
*/

using System;

class ComplicatedSum
{
    static void Main()
    {
        //getting N from console
        Console.Write("Please enter the number N: ");
        int n = int.Parse(Console.ReadLine());

        //getting X from console
        Console.Write("Please enter the number X: ");
        int x = int.Parse(Console.ReadLine());

        //variable holding the sum
        double sum = 1;
        int iFactorial = 1;

        //calculating the sum
        for (int i = 1; i <= n; i++)
        {
            //calculating i factorial
            for (int j = 1; j <= i; j++)
			{
			    iFactorial *= j;
			}

            sum += iFactorial / Math.Pow(x, i);
        }

        Console.WriteLine("The sum is: " + sum);
    }
}
