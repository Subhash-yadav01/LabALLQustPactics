using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
        Write a C# program to demonstrate the use of DateTime data type.
        create a class with the name "Dd" in that write the Main Method 
        In the Main Method:-
        Display the current date and time.
        Display today’s date only (with time set to 00:00:00).
        Display the date and time after 10 days from the current date.
        Use the .GetType() method to display the actual data type of each variable.

 */

namespace LabALLQustPactics
{
    internal class Day3Program6
    {
        static void Main(string[] args)
        {
            DateTime currentDateTime = DateTime.Now;
            Console.WriteLine("Current Date and Time: " + currentDateTime);
            Console.WriteLine("Data type: "+ currentDateTime.GetType());

            DateTime todayDate = DateTime.Today;
            Console.WriteLine("\n Today's Date (time = 00:00:00): " + todayDate);
            Console.WriteLine("Data type: " + todayDate.GetType());

            DateTime furtureDateTime = currentDateTime.AddDays(10); 
            Console.WriteLine("\nDate and Time after 10 days: " + furtureDateTime);
            Console.WriteLine("Data Type: " + furtureDateTime.GetType());
        }
    }
}
