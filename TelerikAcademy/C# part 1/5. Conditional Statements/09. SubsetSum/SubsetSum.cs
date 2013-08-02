/*
 * We are given 5 integer numbers. 
 * Write a program that checks if the sum of some subset of them is 0. 
 * Example: 3, -2, 1, 1, 8 -> 1+1-2=0.
*/

using System;

class SubsetSum
{
    static void Main()
    {
        int[] intVariable = new int[5];
        int sumOfFive = 0;

        //geting integers from console
        for (int i = 0; i < intVariable.Length; i++)
        {
            Console.Write("Please enter valid Integer " + i + ": ");
            intVariable[i] = int.Parse(Console.ReadLine());
        }

        //checking if each number is zero
        for (int i = 0; i < intVariable.Length; i++)
        {
            sumOfFive += intVariable[i];
            if (intVariable[i] == 0)
            {
                Console.WriteLine("[" + intVariable[i] + "]");
            }
        }

        //checking pairs
        for (int i = 0; i < intVariable.Length - 1; i++)
        {
            for (int j = i + 1; j < intVariable.Length; j++)
            {
                if (intVariable[i] + intVariable[j] == 0)
                {
                    Console.WriteLine("[" + intVariable[i] + ", " + intVariable[j] + "]");
                }
            }
        }

        //checking triples
        for (int i = 0; i < intVariable.Length - 2; i++)
        {
            for (int j = i + 1; j < intVariable.Length - 1; j++)
            {
                for (int l = j + 1; l < intVariable.Length; l++)
                {
                    if ((intVariable[i] + intVariable[j] + intVariable[l]) == 0)
                    {
                        Console.WriteLine("[" + intVariable[i] + ", " + intVariable[j] + ", " + intVariable[l] + "]");
                    } 
                }
            }
        }

        //checking subset of four numbers
        for (int i = 0; i < intVariable.Length - 3; i++)
        {
            for (int j = i + 1; j < intVariable.Length - 2; j++)
            {
                for (int l = j + 1; l < intVariable.Length - 1; l++)
                {
                    for (int q = l + 1; q < intVariable.Length; q++)
                    {
                        if ((intVariable[i] + intVariable[j] + intVariable[l] + intVariable[q]) == 0)
                        {
                            Console.WriteLine("[" + intVariable[i] + ", " + intVariable[j] + ", " 
                                + intVariable[l] + ", " + intVariable[q] + "]");
                        }   
                    }                    
                }
            }
        }
        
        //checking all five numbers
        if (sumOfFive == 0)
        {
            Console.WriteLine("[" + intVariable[0] + ", " + intVariable[1] + ", " 
                + intVariable[2] + ", " + intVariable[3] + ", " + intVariable[4] + "]");
        }
    }
}
