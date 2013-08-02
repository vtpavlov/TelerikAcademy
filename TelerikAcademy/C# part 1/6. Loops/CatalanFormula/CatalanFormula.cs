/*
 * Write a program to calculate the Nth Catalan number by given N.
*/

using System;

class CatalanFormula
{
    static void Main()
    {
        double n = 9;
        double nFactorial = n;
        double nPlusOne = n + 1;
        double nTwoProduct = n * 2;
        double nResult = 1;
        double nPlusOneResult = 1;
        double nTwoProductResult = 1;

        for (int i = 1; i <= nFactorial; i++)
        {
            nResult *= i;
        }
        for (int i = 1; i <= nPlusOne; i++)
        {
            nPlusOneResult *= i;

        }
        for (int i = 1; i <= nTwoProduct; i++)
        {
            nTwoProductResult *= i;

        }
        double resul = nTwoProductResult / (nPlusOneResult * nResult);
        Console.WriteLine(resul);
    }
}
