using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
        Write a C# program that demonstrates Var.
        Create a class with the name "Program" in that write the Main Method 
        In the Main Method:-
        using the var keyword to declare variables of different data types (integer, string, and double).
        Print each variable’s value along with its runtime type using the GetType() method.

 */

namespace LabALLQustPactics
{
    internal class Day4Program5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the all variable value.......\n");

            int varInt = 100;
            string varString = "Hello Subhash";
            double varDouble = 34.345f;

            Console.WriteLine("The value of the varInt: " + varInt + " And the data type of varInt is: " + varInt.GetType());
            Console.WriteLine("The value of the varString : " + varString + " And the data type of varString is: " + varString.GetType());
            Console.WriteLine("The value of the varDouble: " + varDouble + " And the data type of varDouble is: " + varDouble.GetType());

            
        }
    }
}
