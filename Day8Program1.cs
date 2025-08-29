using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
       Write a C# program that accepts an integer from the user and determines 
       whether the number is positive, negative, or zero using the ternary operator (?:). 

            Output:-
            Enter a number: -8
            The number is Negative

            Enter a number: 0
            The number is Zero

            Enter a number: 42
            The number is Positive
 */

namespace LabALLQustPactics
{
    internal class Day8Program1
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number: ");

            int num = Convert.ToInt32(Console.ReadLine());

            string rev = (num > 0) ? "The number is positve" : (num == 0) ? "The number is zero" : "The number is negative";
                Console.WriteLine(rev);
        }
    }
}
