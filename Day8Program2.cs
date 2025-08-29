using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
        Write a C# program to find the largest of three numbers entered by the user using Ternary Operator.

        Input:-
        Enter first number: 10
        Enter second number: 25
        Enter third number: 17

        Output:-
        Maximum number is: 25
 */

namespace LabALLQustPactics
{
    internal class Day8Program2
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the firsr number: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the firsr number: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the firsr number: ");
            int c = Convert.ToInt32(Console.ReadLine());

            string res = (a > b && a > c) ? $"Maximum Number is: {a}" : (b > c) ? $"Maximum Number is: {b}" : $"Maximum Number is: {c}";

            Console.WriteLine( res + "is Maximum number" );
        }
    }
}
