using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
        Write a C# program that demonstrates boxing.
        Create a class with the name "Program" in that write the Main Method 
        In the Main Method:-
        Declare a double variable with the value 99.99.
        Convert this Double into an object type.
        Print both the original Double value and the boxed object value.

 */

namespace LabALLQustPactics
{
    internal class Day4Program3
    {
        static void Main(string[] args)
        {
            double num = 99.99;
            object boxed = num;

            Console.WriteLine("Original Double value: " + num);
            Console.WriteLine("Boxed object value: " + boxed);
        }
    }
}
