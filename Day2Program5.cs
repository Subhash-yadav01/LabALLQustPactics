using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
        Write a C# program to revese a Number.
        For Example:-42    
             24
 */

namespace LabALLQustPactics
{
    internal class Day2Program5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number to Reverse:");
            int num = Convert.ToInt32(Console.ReadLine());

            int reverse = 0;
            while (num != 0)
            {
                int digit = num % 10;
                reverse = reverse * 10 + digit;
                num /= 10;
            }
            Console.WriteLine("Reversed Number is: " + reverse);
            

        }
    }
}
