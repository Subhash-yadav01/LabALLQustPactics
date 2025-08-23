using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

//   Write a C# program to check the given number is Even Number.

namespace LabALLQustPactics
{
    internal class Day1Program4
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter the number is: ");
            num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("The given number is even ");
            }
            else
            {
                Console.WriteLine("The given number is odd ");
            }
        }
    }
}
