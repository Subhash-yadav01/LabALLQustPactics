using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
         Write a C# program to read and display account details of a bank customer.
         create a class with the name "Program" in that write the Main Method 

         In the Main Method:-
         The program should take the following inputs from the user:
         Account Holder Name (string)
         Account Number (long)
         Account Balance (decimal)
         Account Active Status (bool → true/false)
         Finally, print the details in a proper format.

 */

namespace LabALLQustPactics
{
    internal class Day6Program3
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the Account Holder Name is: ");
            string accountHolderName = Convert.ToString(Console.ReadLine());

            Console.Write("Enter the Account Number is: ");
            long accountNumber = Convert.ToInt64(Console.ReadLine());

            Console.Write("Enter the Account Balance is: ");
            decimal accountBalance = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Enter the Account Active Status is (ture/ false): ");
            Boolean activeStatus = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("\n------- Account Details --------\n");

            Console.WriteLine("Account Holder Name: " + accountHolderName);
            Console.WriteLine("Account Number: " + accountNumber);
            Console.WriteLine("Account Balance: " + accountBalance);
            Console.WriteLine("Account Active Status: " + activeStatus);

        }
    }
}
