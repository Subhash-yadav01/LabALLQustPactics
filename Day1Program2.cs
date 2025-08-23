using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//   Write a C# program to swap two numbers using a third variable.

namespace LabALLQustPactics
{
    internal class Day1Program2
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            int c;
            Console.WriteLine("Before swapping: a = " + a + ", b = " + b);
            
            c = a;
            a = b;
            b = c;
            Console.WriteLine("After swapping: a = " + a + ", b = " + b);
        }
    }
}
