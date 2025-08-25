using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Write a C# program to demonstrate the use of the boolean (bool) data type.
create a class with the name "------" in that write the Main Method 
In the Main Method:-
Declare a bool variable (for example, isStudent) and assign it a value (true or false).
Print the boolean value with a meaningful message.
Use the .GetType() method to display the actual data type of the variable.

 */

namespace LabALLQustPactics
{
    internal class Day3Program3
    {
        static void Main(string[] args)
        {
            Boolean isStudent = true;
            Console.WriteLine("Is the person a student? " + isStudent);

            Console.WriteLine("The data type of isStudent is : " + isStudent.GetType());
        }
    }
}
