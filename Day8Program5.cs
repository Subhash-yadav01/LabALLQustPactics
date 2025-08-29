using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
        Write a C# program to print numbers from 1 to 100 using a do-while loop.

        Output:-
        1
        2
        3
        ...
        100
 */

namespace LabALLQustPactics
{
    internal class Day8Program5
    {
        static void Main(string[] args)
        {
            int i = 1;
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i <= 100);
        }
    }
}
