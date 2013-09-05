/*
 * Write a program that concatenates two text files into another text file.
*/


using System;
using System.IO;

class ConcatenateTextFiles
{
    static void Main()
    {
        try
        {
            StreamReader firstFile = new StreamReader("first.txt");
            StreamReader secondFile = new StreamReader("second.txt");
            StreamWriter writer = new StreamWriter("output.txt");
            string firstFileData;
            string secondFileData;
            using (firstFile)
            {
                firstFileData = firstFile.ReadToEnd();
                Console.WriteLine("The file first.txt was read successfully!");
            }
            using (secondFile)
            {
                secondFileData = secondFile.ReadToEnd();
                Console.WriteLine("The file second.txt was read successfully!");
            }
            using (writer)
            {
                //Concatenate and write the result in output.txt
                writer.Write(firstFileData + secondFileData);
                Console.WriteLine("The concatenation of the two files was successful and the result is saved in output.txt");
            }
        }
        catch (ArgumentException)
        {
            Console.WriteLine("One or both of the files does not exist!");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("One or both of the files does not exist!");
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("The directory where one of the files or both should be does not exist!");
        }
        catch (UnauthorizedAccessException)   
        {
            Console.WriteLine("There is no permission for writing in the file output.txt!");
        }
        catch (System.Security.SecurityException)   
        {
            Console.WriteLine("A security error has been detected!");
        }
        catch (ObjectDisposedException)
        {
            Console.WriteLine("It has been a problem to write into the file!");
        }
        catch (NotSupportedException)
        {
            Console.WriteLine("Compatibility error!");
        }
        catch (PathTooLongException)
        {
            Console.WriteLine("The path to output.txt is too long!");
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

