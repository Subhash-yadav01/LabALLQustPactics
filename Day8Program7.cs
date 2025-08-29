using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
        Write a C# program  Factorial of a Number using for loop.
        Input:-
        Enter a number to find factorial: 7
        Output:-
        Factorial of 7 is: 5040

 */

namespace LabALLQustPactics
{
    internal class Day8Program7
    {
        static void Main(string[] args)
        {
            int n, fact = 1;

            Console.Write("Enter a number to find factorial: ");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                fact *= i;  // multiplying each number
            }

            Console.WriteLine("Factorial of {0} is: {1}", n, fact);
        }
    }
}
