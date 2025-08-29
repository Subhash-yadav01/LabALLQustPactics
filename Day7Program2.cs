using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
        Write a C# program that asks the user to enter an integer number. Using the relational operator >, 
        check whether the entered number is greater than 100 or not. Display a suitable message based on the result.

        Sample Output:-
        Case 1:- When input number is Greater than or equal to 100
        Enter a number: 150
        150 is greater than 100

 */

namespace LabALLQustPactics
{
    internal class Day7Program2
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the any number: ");
            int num = int.Parse(Console.ReadLine());

            if (num>=100)
            {
                Console.WriteLine(num + " is greater than 100");
            }
            else
            {
                Console.WriteLine(num + " is not greater than 100");
            }
           
        }
    }
}
