using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
         Write a C# program to read and display flight information.
         create a class with the name "Flight" in that write the Main Method 

         In the Main Method:-
         The program should ask the user to enter the following details:
         Flight Number (string)
         Airline (string)
         Departure Time (DateTime in the format yyyy-MM-dd HH:mm)
         Ticket Price (double)
         After taking the inputs, the program should display the flight details in a clear format.

 */

namespace LabALLQustPactics
{
    internal class Day6Program4
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the Flight Number: ");
            int flightNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the Airline: ");
            string airLine = Convert.ToString(Console.ReadLine());

            Console.Write("Enter the Departure Time ( yy-mm-dd HH:mm: ): ");
            DateTime departureTime = Convert.ToDateTime(Console.ReadLine());

            Console.Write("Enter the Ticket Price: ");
            double ticketPrice = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\n---------Flight Details----------\n");

            Console.WriteLine("The Flight Number is: " + flightNumber);
            Console.WriteLine("The Airline is: " + airLine);
            Console.WriteLine("The Departure Time is: " + departureTime);
            Console.WriteLine("The Ticket Price is: " + ticketPrice);

        }
    }
}
