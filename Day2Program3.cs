using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
       Write a C# program to calculate the area of circle.
       Formula:area=pi*r*r
 */

namespace LabALLQustPactics
{
    internal class Day2Program3
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the radius of circle:");
            double radius = Convert.ToDouble(Console.ReadLine());

            // double area = Convert.ToDouble(Console.ReadLine());
            double area = Math.PI * radius * radius;

            Console.WriteLine("Area of circle is: " + area);


        }
    }
}
