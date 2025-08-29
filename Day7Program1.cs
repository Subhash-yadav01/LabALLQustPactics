using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

/*
            Write a C# program to calculate the area and perimeter of a rectangle using arithmetic operators.
            Create a class with the name "---------" in that write the Main Method 
            In the Main Method:-
            length (double)
            width(double)
            Area(double)
            Perimeter(double)
            Calculate the area and Perimeter of Rectangle.
            Use the formula:
            Area = length × width
            Perimeter = 2 × (length + width)
            Finally, display the entered values along with the calculated area and perimeter.

 */

namespace LabALLQustPactics
{
    internal class Day7Program1
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the area of length is: ");
            double length = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the area of width is: ");
            double width = Convert.ToDouble(Console.ReadLine());

            double area = length * width;
            double perimeter = 2 * (length + width);

            Console.WriteLine("\n--- Rectangle Details ---");
            Console.WriteLine("Length: " + length);
            Console.WriteLine("Width: " + width);
            Console.WriteLine("Area: " + area);
            Console.WriteLine("Perimeter: " + perimeter);


        }
    }
}
