using System;

class NumberSequence
{
    static void Main()
    {
        for (int number = 2; number <= 10; number++)
        {
            if (number % 2 == 0)
            {
                Console.Write(number + ", ");
            }
            else
            {
                Console.Write(-number + ", ");
            }
        }
    }
}