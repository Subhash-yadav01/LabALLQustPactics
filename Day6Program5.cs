using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
          Write a C# program to read and display sports player details.
          create a class with the name "Sports" in that write the Main Method 

          In the Main Method:-
          Inputs to be taken from the user:
          Player Name (string)
          Jersey Number (int)
          Average Score (float)
          Is Captain (bool)

 */

namespace LabALLQustPactics
{
    internal class Day6Program5
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the Player Name: ");
            string plyerName = Convert.ToString(Console.ReadLine());

            Console.Write("Enter the Jersey Number: ");
            int jerseyNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the Average Score: ");
            float averageScore = float.Parse(Console.ReadLine());

            Console.Write("Enter the Is Captian (true/false): ");
            Boolean isCaptain = bool.Parse(Console.ReadLine());

            Console.WriteLine("\n----- Player Details ------\n");

            Console.WriteLine("The Player Name is: " + plyerName);
            Console.WriteLine("The player Jersey Number is: " + jerseyNumber);
            Console.WriteLine("The Player Average Score is: " + averageScore);
            Console.WriteLine("The  Player IsCaptain: " + isCaptain);
        }
    }
}
