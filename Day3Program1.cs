using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
       Write a C# program to demonstrate the use of basic data types:-
       create a class with the name "Program" in that write the Main Method 
       In the Main Method:-
       Declare an integer variable and assign it a value.
       Declare a double variable and assign it a value.
       Print both variable values.
       Use the .GetType() method to display the actual data type of each variable.
 */

namespace LabALLQustPactics
{
    internal class Day3Program1 
    {
        static void Main(string[] args)
        {
            int intVar = 25;
            double doubleVar = 99.99;
            Console.WriteLine("Integer Value: " + intVar);
            Console.WriteLine("Double Value: " + doubleVar);
            Console.WriteLine("Data Type of intVar: " + intVar.GetType());
            Console.WriteLine("Data Type of doubleVar: " + doubleVar.GetType());
        }
    }
}
