/*
 * Write a program that downloads a file from Internet 
 * (e.g. http://www.devbg.org/img/Logo-BASD.jpg) and 
 * stores it the current directory. Find in Google 
 * how to download files in C#. Be sure to catch 
 * all exceptions and to free any used resources in the finally block.
*/


using System;
using System.Net;

class FileDownloading
{
    static void Main()
    {
        WebClient webClient = new WebClient();
        Console.Write("Please enter URL: ");
        string url = Console.ReadLine();
        try
        {
            string[] splittedURL = url.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
            string name = splittedURL[splittedURL.Length - 1];
            webClient.DownloadFile(url, name);
            Console.WriteLine("The file is downloaded successfuly!");
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("Please enter valid url!");
        }
        catch (WebException)
        {
            Console.WriteLine("Problem with accessing the network! The url: {0} might be wrong!", url);
        }
        catch (NotSupportedException)
        {
            Console.WriteLine("Does not support the invoked functionality!");
        }
        finally
        {
            webClient.Dispose();
        }
    }
}