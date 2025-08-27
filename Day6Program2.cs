using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
          Write a C# program to read the following car details from the user:
          create a class with the name "Car" in that write the Main Method 

          In the Main Method:-
          Car Number (integer)
          Car Owner Name (string)
          Car Brand (string)
          Car Mileage (double)
          After reading the input, display the details.

 */

namespace LabALLQustPactics
{
    internal class Day6Program2
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the Car Number: ");
            int carNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the Car Owner Name: ");
            string carOwnerName = Console.ReadLine();

            Console.Write("Enter the Car Brand : ");
            string carBrand = Console.ReadLine();

            Console.Write("Enter the Car Mileage: ");
            double carMileage = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\n----------Car Details-------------\n");
            Console.WriteLine("The Car Number is: " + carNumber );
            Console.WriteLine("The Car Owner Name is: " + carOwnerName);
            Console.WriteLine("The Car Brand is : " + carBrand);
            Console.WriteLine("The Car Mileage is: " + carMileage);
        }
    }
}
