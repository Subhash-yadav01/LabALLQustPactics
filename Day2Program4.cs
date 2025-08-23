using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
     Write a C# Sharp program that takes four numbers as input from the user to
     calculate and print the average.
     Expected Output:
     The average of 10 , 15   , 20 , 30 is: 18
 */

namespace LabALLQustPactics
{
    internal class Day2Program4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter four numbers to calculate the average:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            int num2 = Convert.ToInt32(Console.ReadLine());

            int num3 = Convert.ToInt32(Console.ReadLine());

            int num4 = Convert.ToInt32(Console.ReadLine());

            int average = (num1 + num2 + num3 + num4) / 4;

            Console.WriteLine("The average of " + num1 + " , " + num2 + " , " + num3 + " , " + num4 + " is: " + average);
        }
    }
}
