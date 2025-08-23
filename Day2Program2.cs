using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
      Write a C# program to calculate the simple interest.
      Formula: si = p * t * r / 100.
 */

namespace LabALLQustPactics
{
    internal class Day2Program2
    {
        static void Main(string[] args)
        {
            int p, t; 
            float r;
            float si;

            Console.WriteLine("Enter the principal amount:");
            p = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Time in Years:");
            t = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Rate of Interest:");
            r = float.Parse(Console.ReadLine());

            si = p * t * r / 100;
            Console.WriteLine("Simple Interest is: " + si);
        }
    }
}
