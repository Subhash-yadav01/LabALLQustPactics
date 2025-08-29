using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
        Write a C# program to find Armstrong Number Check (for 3-digit numbers).
        Input:-
        Enter a number: 153
        Output:-
        153 is an Armstrong number

 */

namespace LabALLQustPactics
{
    internal class Day8Program8
    {
        static void Main(string[] args)
        {
            int num, originalNum, reminder, result = 0;

            Console.Write("Enter a number: ");
            num = Convert.ToInt32(Console.ReadLine());

            originalNum = num;

            while (num > 0)
            {
                reminder = num % 10; // extract last digit 
                result += reminder * reminder * reminder;  // cube of digit
                num /= 10; // remove last digit
            }

            if(result == originalNum)
                  Console.WriteLine(originalNum + " is an Armstrong number");

            else
            {
                Console.WriteLine(originalNum + " is not a Armstrong number");
            }
           
        }
    }
}
