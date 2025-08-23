using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//   Write a C# program to check the given number is Prime Number.

namespace LabALLQustPactics
{
    internal class Day2Program1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            bool isPrime = true;
            if (num <= 1) {

                isPrime = false;
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(num); i++)
                {
                    if (num % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
            }
            if (isPrime)
                Console.WriteLine(num + " is a prime number.");
            else
                Console.WriteLine(num + " is not a prime number.");
        }
    }
}
