/*
 * Write a program that calculates N!*K! / (K-N)! for given N and K (1<N<K).
*/

using System;

class ComplicatedFactorial
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
        if (k < 1 || n < 1 || k <= n)
        {
            Console.WriteLine("Wrong input!");

        }
        else
        {
            //variables holding the factorial of n and k
            int nFactorial = 1;
            int kFactorial = 1;
            int kMinusNFactorial = 1;

            //loop to calculate N! and K! and (K-N)!
            for (int i = 1; i <= k; i++)
            {
                if (i <= (k - n))
                {
                    kMinusNFactorial *= i;
                }

                if (i <= n)
                {
                    nFactorial *= i;
                    kFactorial *= i;
                }
                else
                {
                    kFactorial *= i;
                }
            }

            //printing the result
            Console.WriteLine("The result from N!*K! / (K-N)! is: {0}", (nFactorial * kFactorial) / (double)kMinusNFactorial);
        }
    }
}
