using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
        Write a C# program to give a week day by using Switch case.

        Input:-
        Enter a number (1 to 7): 3

        Output:-
        Wednesday      
 */

namespace LabALLQustPactics
{
    internal class Day8Program4
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number (1 to 7): ");
            int day = Convert.ToInt32(Console.ReadLine());

            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;

                case 2:
                    Console.WriteLine("Tuesday");
                    break;

                case 3:
                    Console.WriteLine("Wednesday");
                    break;

                case 4:
                    Console.WriteLine("Thursday");
                    break;

                case 5:
                    Console.WriteLine("Friday");
                    break;

                case 6:
                    Console.WriteLine("Saturday");
                    break;

                case 7:
                    Console.WriteLine("Sunday");
                    break;

                default:
                    Console.WriteLine("nvalid input! Please enter a number between 1 and 7.");
                    break;
            }


            
        }
    }
}
