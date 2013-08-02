/*
 * Write a method that adds two polynomials. 
 * Represent them as arrays of their coefficients .
*/

using System;
using System.Text;

class AddingPolynomials
{
    static int[] AddPolynomials(int[] firstPolynom, int[] secondPolynom)
    {
        int firstPolynomLength = firstPolynom.Length;
        int secondPolynomLength = secondPolynom.Length;

        int[] resultPolynom;

        if (firstPolynomLength >= secondPolynomLength)
        {
            resultPolynom = new int[firstPolynomLength];
            for (int i = 0; i < secondPolynomLength; i++)
            {
                resultPolynom[i] = firstPolynom[i] + secondPolynom[i];
            }
            for (int i = secondPolynomLength; i < firstPolynomLength; i++)
            {
                resultPolynom[i] = firstPolynom[i];
            }
        }
        else
	    {
            resultPolynom = new int[secondPolynomLength];
            for (int i = 0; i < firstPolynomLength; i++)
            {
                resultPolynom[i] = firstPolynom[i] + secondPolynom[i];
            }
            for (int i = firstPolynomLength; i < secondPolynomLength; i++)
            {
                resultPolynom[i] = secondPolynom[i];
            }
	    }
        return resultPolynom;
    }

    static void Main()
    {
        int[] firstPolynom = { 5, 0, 1 };
        int[] secondPolynom = { 4, 2, 4, 3 };
        //printing the result polynom from (firstPolynom + secondPolynom)
        foreach (var item in AddPolynomials(firstPolynom,secondPolynom))
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}
