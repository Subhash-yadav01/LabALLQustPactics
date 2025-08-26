using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
      Write a C# program to demonstrate the use of float and decimal data types.
      create a class with the name " ---------" in that write the Main Method 
      In the Main Method:-
      Declare a float variable and assign a value.
      Declare a decimal variable and assign a value.
      Print their values.
      Use the .GetType() method to display the actual data type of each variable.

 */

namespace LabALLQustPactics
{
    internal class Day3Program5
    {
        static void Main(string[] args)
        {

            float pi = 34.5f;
            decimal point = 34523.345m;

            Console.WriteLine("The value of pi is: " + pi);
            Console.WriteLine("The value of point is: " + point);

            Console.WriteLine("The data type of float variable is: " + pi.GetType());
            Console.WriteLine("The data type of decimal variable is: " + point.GetType());

        }
    }
}
