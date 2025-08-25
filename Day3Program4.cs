using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
     Write a C# program to demonstrate the use of GUIDs (Globally Unique Identifiers).
     create a class with the name "-----" in that write the Main Method 
     In the Main Method:-
     Declare a Guid  two variables (id1 and id2) using Guid.NewGuid().
     Print both GUID values 
     Use the .GetType() method to display the actual data type of the variable.

 */

namespace LabALLQustPactics
{
    internal class Day3Program4
    {
        static void Main(string[] args)
        {
            Guid id1 = Guid.NewGuid();
            Guid id2 = Guid.NewGuid();

            Console.WriteLine("The first Guid: " + id1);
            Console.WriteLine("The second Guid: " + id2);

            Console.WriteLine("The data type of id1 is: " + id1.GetType());
            Console.WriteLine("The data type of id2 is: " + id2.GetType());
        }
    }
}
