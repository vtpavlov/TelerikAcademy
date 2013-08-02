/*
 * Write a program that calculates N!/K! for given N and K (1<K<N).
*/

using System;

class Factorial
{
    static void Main()
    {
        //getting N from console
        Console.Write("Please enter the number N: ");
        int n = int.Parse(Console.ReadLine());

        //getting K from console
        Console.Write("Please enter the number K: ");
        int k = int.Parse(Console.ReadLine());

        //validating 1<k<n
        if (k < 1 || n < 1 || k > n)
        {
            Console.WriteLine("Wrong input!");

        }
        else
        {
            //variables holding the factorial of n and k
            int nFactorial = 1;
            int kFactorial = 1;

            //loop to calculate N! and K!
            for (int i = 1; i <= n; i++)
            {
                if (i <= k)
                {
                    nFactorial *= i;
                    kFactorial *= i;
                }
                else
                {
                    nFactorial *= i;
                }
            }

            //printing the result from N!/K!
            Console.WriteLine("The result from N!/K! is: {0}", nFactorial / kFactorial);
        }
    }
}
