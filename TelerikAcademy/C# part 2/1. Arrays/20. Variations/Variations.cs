/*
 * Write a program that reads two numbers N and K and generates all 
 * the variations of K elements from the set [1..N]. 
 * Example: N = 3, K = 2  {1, 1}, {1, 2}, {1, 3}, {2, 1}, {2, 2}, {2, 3}, {3, 1}, {3, 2}, {3, 3}
*/

using System;

class Variations
{
    static int N;
    static int K;
    static int[] loops;

    static void NestedLoops(int currentLoop)
    {
        if (currentLoop == N)
        {
            PrintLoops();
            return;
        }
        for (int counter = 1; counter <= K; counter++)
        {
            loops[currentLoop] = counter;
            NestedLoops(currentLoop + 1);
        }
    }
    static void PrintLoops()
    {
        Console.Write("{");
        for (int i = 0; i < N; i++)
        {
            Console.Write("{0} ", loops[i]);
        }
        Console.Write("}");
        Console.WriteLine();

    }

    static void Main(string[] args)
    {                
        Console.Write("Please enter the number N: ");        
        K = int.Parse(Console.ReadLine());
        Console.Write("Please enter the number K: ");
        N = int.Parse(Console.ReadLine());
        loops = new int[N];
        NestedLoops(0);
    }
}
