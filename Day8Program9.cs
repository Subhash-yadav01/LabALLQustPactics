using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Write a C# program to count the number of digits in an integer.
    Input:-
    Enter a number: 1234
    Output:-
    Number of digits in 1234 is: 4 
 */

namespace LabALLQustPactics
{
    internal class Day8Program9
    {
        static void Main(string[] args)
        {
           Console.Write("Enter  a number: ");
           int number = Convert.ToInt32(Console.ReadLine());

            int count = 0;
            int temp = Math.Abs(number); // Handdle negative numbers also

            if(temp == 0)
            {
                count = 1;
            }
            else
            {
                while (temp > 0)
                {
                    temp = temp / 10;
                    count++;
                }
            }

            Console.WriteLine($"Number of digits in {number} is: {count}");
        }
    }
}
