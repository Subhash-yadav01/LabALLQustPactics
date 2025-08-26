using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
     Write a C# program to demonstrate boxing and unboxing with a double value.
     Create a class with the name "Program" in that write the Main Method 
     In the Main Method:-
     Declare a double variable with the value 3.14159.
     Convert it into an object.
     Unbox it back into a double.
     Print the original value, the boxed object, and the unboxed value.
*/

namespace LabALLQustPactics
{
       internal class Day4Program4
    {
        static void Main(string[] args)
        {
            double num = 3.14159;
            object obj = num;
            double unboxed = (double)obj;

            Console.WriteLine("Original Double value: " + num);
            Console.WriteLine("Boxed object value: " + obj);
            Console.WriteLine("Unboxed Double value: " + unboxed);
        }
    }
}
