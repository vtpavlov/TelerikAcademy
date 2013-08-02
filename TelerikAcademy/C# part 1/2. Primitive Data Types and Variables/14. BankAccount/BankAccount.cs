/*
 * A bank account has a holder name (first name, 
 * middle name and last name), available amount of 
 * money (balance), bank name, IBAN, BIC code and 3 
 * credit card numbers associated with the account. 
 * Declare the variables needed to keep the 
 * information for a single bank account using the 
 * appropriate data types and descriptive names.
*/

using System;

class BankAccount
{
    static void Main()
    {
        string firstName;
        string middleName;
        string lastName;
        decimal balance; // decimal because it's holding the amount of money and we need precision
        string bankName; 
        string IBAN; // string because IBAN might have letters
        string BIC;  //string because the BIC codes are from letters
        string creditCardNumberOne; //string because the number might start with zero
        string creditCardNumberTwo;
        string creditCardNumberThree;
    }
}
