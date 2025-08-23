using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//   Write a C# program to swap two numbers without using a third variable.

namespace LabALLQustPactics
{
    internal class Day1Program3
    {
        static void Main(string[] args)
        {
            int a = 40;
            int b = 20;
            Console.WriteLine("Before swapping: a = " + a + ", b = " + b);
            a = a + b; // a now becomes 30
            b = a - b; // b becomes 10
            a = a - b; // a becomes 20
            Console.WriteLine("After swapping: a = " + a + ", b = " + b);
        }
    }
}
