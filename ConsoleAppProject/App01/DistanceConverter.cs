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
        public const double FEET_IN_MILES = 5280.00;
        public const double METRES_IN_MILES = 1609.34;
        public const double FEET_IN_METRES = 3.28084;

        /// <summary>
        /// Starts a distance converter;
        /// </summary>
        public void Run()
        {
            Console.WriteLine("Welcome to Distance Converter");
            Console.WriteLine("Made by Daniils Pucko");
            Console.WriteLine("Choose what distance unit you want to convert: ");
            Console.WriteLine("1. Miles");
            Console.WriteLine("2. Feet");
            Console.WriteLine("3. Metres");
            ChooseConverter();
        }


        /// <summary>
        /// Prompts user to select distance unit to convert from.
        /// </summary>
        public void ChooseConverter()
        {
            Console.Write("Please enter your choice number > ");
            string choice = Console.ReadLine();
            if(choice == "1") 
            {
                Console.WriteLine("You have chosen Miles.");
                InputMiles();
            }
            else if (choice == "2")
            {
                Console.WriteLine("You have chosen Feet.");
                InputFeet();
            }
            else if (choice == "3")
            {
                Console.WriteLine("You have chosen Metres.");
                InputMetres();
            }
            else 
            {
                Console.WriteLine("You entered wrong number. Try again > ");
                ChooseConverter();
            }
        }



        /// <summary>
        /// Asks user to input a distance in miles.
        /// </summary>
        public void InputMiles()
        {
            Console.Write("Please enter the number of miles > ");
            string value = Console.ReadLine();
            miles = Convert.ToDouble(value);
            CalculateFromMiles();
        }

        /// <summary>
        /// Asks user to input a distance in feet.
        /// </summary>
        public void InputFeet()
        {
            Console.Write("Please enter the number of feet > ");
            string value = Console.ReadLine();
            feet = Convert.ToDouble(value);
            CalculateFromFeet();
        }

        /// <summary>
        /// Asks user to input a distance in metres.
        /// </summary>
        public void InputMetres()
        {
            Console.Write("Please enter the number of meters > ");
            string value = Console.ReadLine();
            metres = Convert.ToDouble(value);
            CalculateFromMetres();
        }

        /// <summary>
        /// Asks user to input a unit to convert from miles to.
        /// </summary>
        private void CalculateFromMiles()
        {
            Console.WriteLine("Select distance unit to convert to:");
            Console.WriteLine("1: Feet");
            Console.WriteLine("2: Metres");
            Console.Write("Please enter your choice number > ");
            string choice = Console.ReadLine();
            if (choice == "1") 
            {
                Console.WriteLine("You have selected feet");
                MilesToFeet();
            }
            else if (choice == "2")
            {
                Console.WriteLine("You have selected metres");
                MilesToMetres();
            }
            else
            {
                Console.WriteLine("You have selected invalid method. Try again.");
                CalculateFromMiles();
            }
        }

        /// <summary>
        /// Asks user to input a unit to convert from feet to.
        /// </summary>
        private void CalculateFromFeet()
        {
            Console.WriteLine("Select distance unit to convert to:");
            Console.WriteLine("1: Miles");
            Console.WriteLine("2: Metres");
            Console.Write("Please enter your choice number > ");
            string choice = Console.ReadLine();
            if (choice == "1") 
            {
                Console.WriteLine("You have selected miles");
                FeetToMiles();
            }
            else if (choice == "2")
            {
                Console.WriteLine("You have selected metres");
                FeetToMetres();
            }
            else
            {
                Console.WriteLine("You have selected invalid method. Try again.");
                CalculateFromFeet();
            }
        }

        /// <summary>
        /// Asks user to input a unit to convert from metres to.
        /// </summary>
        private void CalculateFromMetres()
        {
            Console.WriteLine("Select distance unit to convert to:");
            Console.WriteLine("1: Feet");
            Console.WriteLine("2: Miles");
            Console.Write("Please enter your choice number > ");
            string choice = Console.ReadLine();
            if (choice == "1") 
            {
                Console.WriteLine("You have selected feet");
                MetresToFeet();
            }
            else if (choice == "2")
            {
                Console.WriteLine("You have selected metres");
                MetresToMiles();
            }
            else
            {
                Console.WriteLine("You have selected invalid method. Try again.");
                CalculateFromMetres();
            }
        }
        
        ///Calculation and output.
        private void MilesToFeet()
        {
            feet = miles * FEET_IN_MILES;
            Console.WriteLine("There are " + feet + " feet in " + miles + " miles.");
        }

        private void MilesToMetres()
        {
            metres = miles * METRES_IN_MILES;
            Console.WriteLine("There are " + metres + " metres in " + miles + " miles.");
        }

        private void FeetToMiles()
        {
            miles = feet / FEET_IN_MILES;
            Console.WriteLine("There are " + miles + " miles in " + feet + " feet.");
        }

        private void FeetToMetres()
        {
            metres = feet / FEET_IN_METRES;
            Console.WriteLine("There are " + metres + " meters in " + feet + " feet.");
        }

        private void MetresToMiles()
        {
            miles = metres / METRES_IN_MILES;
            Console.WriteLine("There are " + miles + " miles in " + metres + " metres.");
        }

        private void MetresToFeet()
        {
            feet = metres * FEET_IN_METRES;
            Console.WriteLine("There are " + feet + " feet in " + metres + " metres.");
        }
    }
}
