/*
 * Write a program to calculate the sum 
 * (with accuracy of 0.001): 1 + 1/2 - 1/3 + 1/4 - 1/5 + ...
 * 
 * Следвал съм инструкциите от книгата при решението
*/

using System;

class AccurateSum
{
    static void Main()
    {
        //variable holding the sum
        float sum = 1f;
        
        //variable holding the sum -1 iteration
        float oldSum = 0f;

        //counter for the cycle
        int i = 2;

        //calculating the result
        while(Math.Abs(sum - oldSum) > 0.001f)
        {            
            oldSum = sum;
            sum += ((i % 2) == 0) ? (1.0f / i) : (-1.0f / i);
            i++;            
        }

        //printing the result
        Console.WriteLine("The sum with accuracy 0.001 is: {0:F3}", sum);
    }
}
