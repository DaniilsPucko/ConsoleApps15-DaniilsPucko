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
        public const int FEET_IN_MILES = 5280;

        public void Run()
        {
            OutputHeading();
            InputMiles();
            OutputFeet();
        }

        private void OutputHeading()
        {
            Console.WriteLine("\n----------------------------------");
            Console.WriteLine("        Convert Miles to Feet       ");
            Console.WriteLine("          by Daniils Pucko          ");
            Console.WriteLine("----------------------------------\n");
        }

        /// <summary>
        /// Asks user to input a distance in miles and to convert it into feet.
        /// </summary>
        private void InputMiles()
        {
            Console.Write("Please enter the number of miles > ");
            string value = Console.ReadLine();
            miles = Convert.ToDouble(value);
        }

        /// <summary>
        /// Calculates how many feet there are in inputed amount of miles.
        /// </summary>
        private void CalculateFeet()
        {
            feet = miles * 5280;
        }

        /// <summary>
        /// Outputs an amount of feet.
        /// </summary>
        private void OutputFeet()
        {
            Console.WriteLine(miles + " miles is " + feet + " feet.");
        }

    }
}
