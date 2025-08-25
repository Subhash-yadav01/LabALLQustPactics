using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Write a C# program to demonstrate the use of string and char data types.
create a class with the name "-------" in that write the Main Method 
In the Main Method:-
Declare a string variable to store your name.
Declare a char variable to store the first letter of your name.
Print both the string and char values.
Use the .GetType() method to display the actual data type of each variable.

 */

namespace LabALLQustPactics
{
    internal class Day3Program2
    {
        static void Main(string[] args)
        {
            string name = "Subhash";
            char firstLetter = 'S';

            Console.WriteLine("My Name is: " + name);
            Console.WriteLine("The first letter of My Name is: " + firstLetter);

            Console.WriteLine("The data type of My 'name' variable is: " + name.GetType());
            Console.WriteLine("The data type of first letter variable is: " + firstLetter.GetType());
        }
    }
}
