using System;
namespace ConsoleAppProject.App02
{
    /// <summary>
    /// Calculates BMI and outputs result, describing risks.
    /// </summary>
    /// <author>
    /// Daniils Pucko. Version 02.03.2001.
    /// </author>
    public class BMI
    {
        ///Adding variables for calculator.
        private double kg;
        private double pounds;
        private double metres;
        private double stones;
        private double inches;
        private double feet;
        public const double POUNDS_IN_STONE = 14;
        public const double INCHES_IN_FEET = 12;

        public void Run()
        {
            OutputHeading();
            ChooseUnits();
        }

        ///Tells about a program and asks user to choose unit.
        private void OutputHeading()
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Body Mass Index Calculator by Daniils Pucko");
            Console.WriteLine("    This program will calculate your BMI   ");
            Console.WriteLine("  To Start choose units in which you will  ");
            Console.WriteLine("      provide your height and weight.      ");
            Console.WriteLine("1. Stones, pounds & feet, inches");
            Console.WriteLine("2. Metres & KG");
        }

        ///Prompts user to input choice number and goes to needed method.
        private void ChooseUnits()
        {
            Console.Write("Please enter your choice number > ");
            string choice = Console.ReadLine();
            if (choice == "1") 
            {
                Console.WriteLine("You have chosen first method.");
                PoundsCalculator();
            }
            else if (choice == "2")
            {
                Console.WriteLine("You have chosen second method.");
                MetricCalculator();
            }
            else
            {
                Console.WriteLine("You have entered wrong number. Try again.");
                ChooseUnits();
            }
        }

        private void PoundsCalculator()
        {
            Console.WriteLine("Choose weight units: ");
            Console.WriteLine("1. Stones");
            Console.WriteLine("2. Pounds");
            Console.Write("Enter your choice number > ");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                Console.WriteLine("");
                Console.WriteLine("You have chosen stones.");
                Console.Write("Enter your weight in stones > ")
            }
        }
    }
}
