/*
 * Write a program that creates an array containing all letters from the alphabet (A-Z). 
 * Read a word from the console and print the index of each of its letters in the array.
*/

using System;

class AlphabetArray
{
    static void Main()
    {
        Console.Write("Please enter a word: ");
        string word = Console.ReadLine();

        char[] alphabet = new char[26];

        for (int i = 0; i < 26; i++)
        {
            //Fill the alphabet with letters
            alphabet[i] = (char)('a' + i);
        }

        //printing the alphabet
        Console.WriteLine();
        Console.WriteLine("This is the alphabet:");
        for (int i = 0; i < 26; i++)
        {
            Console.Write("Index: " + i + "; Letter: " + alphabet[i].ToString() + "\n");
        }

        //binary search for each letter from the word
        foreach (char element in word)
        {
            int low = 0; // low end of the search area
            int high = 25; // high end of the search area
            int middle = (low + high + 1) / 2; // middle element
            int index = -1;
            do // loop to search for element
            {
                
                // if the element is found at the middle
                if (element == alphabet[middle])
                {
                    index = middle;
                }
                // middle element is too high
                else if (element < alphabet[middle])
                {
                    high = middle - 1; // eliminate the higher half
                }
                else // middle element is too low
                {
                    low = middle + 1; // eliminate the lower half
                }
                middle = (low + high + 1) / 2; // recalculate the middle
            } while ((low <= high) && (index == -1));

            Console.WriteLine();
            Console.Write("This is the index of the letter {0}: ", element.ToString());
            Console.WriteLine(index);
        }            
    }
}

