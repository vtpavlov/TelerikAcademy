/*
 * Write an expression that checks if given positive 
 * integer number n (n ≤ 100) is prime. E.g. 37 is prime.
*/

using System;

class PositiveInt
{
    static void Main()
    {
        //Getting string input and converting it to unsinged integer
        Console.Write("Please enter a positive number between [0, 100] to check if it's prime: ");
        uint positiveNumber = uint.Parse(Console.ReadLine());
        
        //bool variable holding the result if the number is prime or not
        bool isPrime = true;

        //check if the number is between 0 and 100
        if (positiveNumber <= 0 || positiveNumber > 100)
        {
            Console.WriteLine("The number u entered is incorrect!");
        }
        else
        {            
            if (positiveNumber == 1) isPrime = false; // 1 is not prime
            if (positiveNumber == 2) isPrime = true;  // 2 is prime

            //an expression checking if positiveNumber is prime
            for (int i = 2; i < positiveNumber; ++i)
            {
                if (positiveNumber % i == 0) isPrime = false;
            }

            //printing the result
            Console.WriteLine("The number {0} is prime: " + isPrime, positiveNumber);
        }
    }
}