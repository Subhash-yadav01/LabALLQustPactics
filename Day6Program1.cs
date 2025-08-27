using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
       Write a C# program to read the following details of an employee from the user:
       create a class with the name "Employee" in that write the Main Method 

       In the Main Method:-
       Employee Name (string)
       Employee Id (integer)
       Employee Salary (double)
       After taking the input, display the details.

 */

namespace LabALLQustPactics
{
    internal class Day6Program1
    {
        static void Main(string[] args)
        {

            Console.Write("Enter Employee Name: ");
            string empName = Console.ReadLine();

            Console.Write("Enter Employee Id: ");
            int empId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Employee Salary: ");
            double empSalary = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\n--- Employee Details ---");
            Console.WriteLine("Employee Name   : " + empName);
            Console.WriteLine("Employee Id     : " + empId);
            Console.WriteLine("Employee Salary : " + empSalary);


        }
    }
}
