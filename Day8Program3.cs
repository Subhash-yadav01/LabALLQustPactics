using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
        Write a C# program to find the largest of three numbers using if-else statements.
        Input:-
        Enter first number: 10  
        Enter second number: 25  
        Enter third number: 17

        Output:-
        The largest number is: 25

 */

namespace LabALLQustPactics
{
    internal class Day8Program3
    {
        static void Main(string[] args)
        {
            Console.Write("Enter num1: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter num2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter num3: ");
            int num3 = Convert.ToInt32(Console.ReadLine());


            if(num1 > num2 && num1 > num3)
            {
                Console.WriteLine("the largest number is: " + num1);
            }
            else if(num2 > num1 && num2 > num3)
            {
                Console.WriteLine("the largest number is: " + num2);
            }
            else
            {
                Console.WriteLine("the largest number is: " + num3);
            }


        }
    }
}
