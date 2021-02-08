using System;
namespace ConsoleAppProject.App01
{
    /// <summary>
    /// This program converts distance units to other distance units.
    /// </summary>
    /// <author>
    /// Daniils Pucko (07.02.2021)
    /// </author>
    public class DistanceConverter
    {
        private double miles;
        private double feet;
        private double metres;
        public const int FEET_IN_MILES = 5280;
        public const double METRES_IN_MILES = 1609.34;

        /// <summary>
        /// Starts a distance converter;
        /// </summary>
        public void Run()
        {
            OutputHeading();
            ChooseConverter();
        }

        /// <summary>
        /// Outputs heading of program and choices of converter.
        /// </summary>
        private void OutputHeading()
        {
            Console.WriteLine("\n----------------------------------");
            Console.WriteLine("         Distance Converter         ");
            Console.WriteLine("          by Daniils Pucko          ");
            Console.WriteLine("----------------------------------\n");
            Console.WriteLine("CHOOSE WHAT YOU WANT TO CONVERT:");
            Console.WriteLine("1: Miles to Feet.");
            Console.WriteLine("2: Feet to Miles");
            Console.WriteLine("3: Miles to Metres");
        }

        /// <summary>
        /// Prompts user to input a number of choice and enables needed method
        /// </summary>
        private void ChooseConverter()
        {
            Console.Write("Please enter your choice number > ");
            string choice = Console.ReadLine();
            if(choice == "1") 
            {
                InputMiles();
            }
            else if (choice == "2")
            {
                InputFeet();
            }
            else if (choice == "3")
            {
                InputMiles2Metres();
            }
            else 
            {
                Console.WriteLine("You entered wrong number. Try again > ");
                ChooseConverter();
            }
        }

        /// <summary>
        /// Asks user to input a distance in miles and to convert it into feet.
        /// </summary>
        private void InputMiles()
        {
            Console.Write("Please enter the number of miles > ");
            string value = Console.ReadLine();
            miles = Convert.ToDouble(value);
            CalculateFeet();
        }

        /// <summary>
        /// Asks user to input a distance in feet and to convert it into miles.
        /// </summary>
        private void InputFeet()
        {
            Console.Write("Please enter the number of feet > ");
            string value = Console.ReadLine();
            feet = Convert.ToDouble(value);
            CalculateMiles();
        }

        /// <summary>
        /// Asks user to input a distance in miles and to convert it into metres.
        /// </summary>
        private void InputMiles2Metres()
        {
            Console.Write("Please enter the number of miles > ");
            string value = Console.ReadLine();
            miles = Convert.ToDouble(value);
            CalculateMetres();
        }

        /// <summary>
        /// Calculates how many one distance unit there is in other distance unit.
        /// </summary>
        private void CalculateFeet()
        {
            feet = miles * FEET_IN_MILES;
            OutputFeet();
        }

        private void CalculateMiles()
        {
            miles = feet / FEET_IN_MILES;
            OutputMiles();
        }

        private void CalculateMetres()
        {
            metres = miles * METRES_IN_MILES;
            OutputMetres();
        }

        /// <summary>
        /// Outputs an amount of one distance unit in another distance unit.
        /// </summary>
        private void OutputFeet()
        {
            Console.WriteLine(miles + " miles is " + feet + " feet.");
        }

        private void OutputMiles()
        {
            Console.WriteLine(feet + " feet is " + miles + " miles.");
        }

        private void OutputMetres()
        {
            Console.WriteLine(miles + " miles is " + metres + " metres.");
        }

    }
}
