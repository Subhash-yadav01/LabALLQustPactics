using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
            Write a C# program that demonstrates boxing.
            create a class with the name "Program" in that write the Main Method 
            In the Main Method:-
            Declare an integer variable with the value 100.
            Convert this integer into an object type.
            Print both the original integer value and the boxed object value.
            Output:-
            Original integer value: 42
            Boxed object value: 42
 */

namespace LabALLQustPactics
{
    internal class Day4Program1
    {
        static void Main(string[] args)
        {

            int num1 = 100;
            object boxed1 = num1;

            Console.WriteLine("\nOriginal Integer value: " + num1);
            Console.WriteLine("Boxed object value: " + boxed1);


            int num = 42;
            object boxed = num;

            Console.WriteLine("\nOriginal Integer value: " + num);
            Console.WriteLine("Boxed object value: " + boxed); 
        }
    }
}
