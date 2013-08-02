/*
 * A company has name, address, phone number, fax number, 
 * web site and manager. The manager has first name, 
 * last name, age and a phone number. Write a program 
 * that reads the information about a company and 
 * its manager and prints them on the console.
*/

using System;

class CompanyInfo
{
    static void Main()
    {
        string companyName;
        string companyAddress;
        string phoneNumber;
        string faxNumber;
        string webSite;
        string manager;
        string managerFirstName;
        string managerLastName;
        byte managerAge;
        string managerPhoneNumber;

        //request for company name
        Console.Write("Please enter the company name: ");
        companyName = Console.ReadLine();

        //request for company address
        Console.Write("Please enter the company address: ");
        companyAddress = Console.ReadLine();

        //request for company phone number
        Console.Write("Please enter the company phone number: ");
        phoneNumber = Console.ReadLine();

        //request for company fax number
        Console.Write("Please enter the company fax number: ");
        faxNumber = Console.ReadLine();

        //request for company web site
        Console.Write("Please enter the company web site: ");
        webSite = Console.ReadLine();

        //request for managerFirstName
        Console.Write("Please enter the first name of the manager: ");
        managerFirstName = Console.ReadLine();

        //request for managerlastName
        Console.Write("Please enter the last name of the manager: ");
        managerLastName = Console.ReadLine();

        //request for managerAge
        Console.Write("Please enter the age of the manager: ");
        managerAge = byte.Parse(Console.ReadLine());

        //request for managerPhoneNumber
        Console.Write("Please enter the manager's phone number: ");
        managerPhoneNumber = Console.ReadLine();

        manager = String.Format("The manager is: {0} {1},\nhe is {2} years old and his phone number is: {3}",
            managerFirstName, managerLastName, managerAge, managerPhoneNumber);

        //printing the company info
        Console.WriteLine("\n\n\nThe name of the company: {0}\ncompany's address: {1}\ncompany's phone number: {2}\n"+
            "company's fax number: {3}\ncompany's web site: {4}\n\n{5}", companyName, companyAddress, phoneNumber, 
            faxNumber, webSite, manager);
    }
}

