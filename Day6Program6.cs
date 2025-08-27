using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
         Write a C# program that reads a single character from the user and displays:
         create a class with the name "Aschar" in that write the Main Method 

         In the Main Method:-

         Inputs to be taken from the user:
         myChar (char)
         Print the details
         The character entered.
         Its ASCII value.

 */

namespace LabALLQustPactics
{
    internal class Day6Program6
    {
        static void Main(string[] args)
        {
            Console.Write("Entre the any Character: ");
            char myChar = (Console.ReadLine()[0]);

            int asciiValue = (int)myChar;

            Console.WriteLine("\n--- Character Details ---\n");

            Console.WriteLine("Character   : " + myChar);
            Console.WriteLine("ASCII Value : " + asciiValue);
        }
    }
}
