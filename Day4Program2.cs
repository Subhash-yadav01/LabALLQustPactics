using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
          Write a C# program to demonstrate boxing and unboxing with an integer.
          Create a class with the name "Program" in that write the Main Method 
          In the Main Method:-
          Declare an integer variable with the value 100.
          Convert this integer into an object type.
          Unbox the object back into an integer.
          Print the original integer, the boxed object, and the unboxed integer.

 */

namespace LabALLQustPactics
{
    internal class Day4Program2
    {
        static void Main(string[] args)
        {
            int i = 100;
            object boxed = i;

            int unboxed = (int)boxed;

            Console.WriteLine("Original integer value: " + i);
            Console.WriteLine("Boxed object value: " + boxed);
            Console.WriteLine("Unboxed integer value: " + unboxed);
        }

    }
}
