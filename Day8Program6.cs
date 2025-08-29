using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
        Write a C# program Sum of First N Natural Numbers using while loop
        Input:-
        Enter a number (N): 5
        Output:-
        Sum of first 5 natural numbers = 15

 */

namespace LabALLQustPactics
{
    internal class Day8Program6
    {
        static void Main(string[] args)
        {
            int N, sum = 0, i = 1;

            Console.Write("Enter a number (N): ");
            N = Convert.ToInt32(Console.ReadLine());

            while (i <= N)
            {
                sum += i; // add current number
                i++;    // move to next number
            }
            Console.WriteLine("Sum of first {0} natural numbers = {1}" , N , sum);
        }
    }
}
