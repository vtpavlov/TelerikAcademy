/*
 * Write a program that compares two text files line by line and prints the 
 * number of lines that are the same and the number of lines that are different. 
 * Assume the files have equal number of lines.
*/


using System;
using System.IO;

class FileCompare
{
    static void Main()
    {
        try
        {
            StreamReader firstFile = new StreamReader("first.txt");
            StreamReader secondFile = new StreamReader("second.txt");
            //Counter for the equal lines
            int numberOfEquals = 0;
            //Counter for the lines that are different
            int numberOfDifferent = 0;
            using (firstFile)
            {
                using (secondFile)
                {
                    //Reading the first lines of both files
                    string firstFileLine = firstFile.ReadLine();
                    string secondFileLine = secondFile.ReadLine();

                    while (firstFileLine != null && secondFileLine != null)
                    {
                        //Check if they are equal
                        if (firstFileLine == secondFileLine)
                        {
                            numberOfEquals++;
                        }
                        else
                        {
                            numberOfDifferent++;
                        }
                        //Reading the next lines 
                        firstFileLine = firstFile.ReadLine();
                        secondFileLine = secondFile.ReadLine();
                    }
                }
            }
            //Printing the result
            Console.WriteLine("There are {0} equal lines and {1} different.", numberOfEquals, numberOfDifferent);
        }
        catch (ArgumentException)
        {
            Console.WriteLine("One or both if the files does not exist!");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("One or both if the files does not exist!");
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("The directory where the files should be does not exist!");
        }
        catch (IOException)
        {
            Console.WriteLine("IO Exception has accured!");
        }
        catch (OutOfMemoryException)
        {
            Console.WriteLine("Out of memory!");
        }     
    }
}