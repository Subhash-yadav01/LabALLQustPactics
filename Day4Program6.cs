using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
       create a class with the name "Program" in that write the Main Method 
       In the Main Method:-
       using the dynamic keyword to store different types of values (integer, string, and double) in the same variable.
       Print the value and its runtime type after each assignment using the GetType() method.

 */

namespace LabALLQustPactics
{
    internal class Day4Program6
    {
        static void Main(string[] args)
        {
            dynamic value;

            value = 42;
            Console.WriteLine("value: " + value + ", Type: " + value.GetType());

            value = "Hello Subhash !!!";
            Console.WriteLine("value: " + value + ", Type: " + value.GetType());

            value = 3.14159;
            Console.WriteLine("value: " + value + ", Type: " + value.GetType());
        }
    }
}
