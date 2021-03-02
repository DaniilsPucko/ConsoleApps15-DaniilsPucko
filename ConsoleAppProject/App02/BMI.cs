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
        private double index;
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
                KGCalculator();
            }
            else
            {
                Console.WriteLine("You have entered wrong number. Try again.");
                ChooseUnits();
            }
        }

        ///prompts users to choose between stones and pounds and to enter their weight.
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
                Console.Write("Enter your weight in stones > ");
                string weight = Console.ReadLine();
                stones = Convert.ToDouble(weight);
                pounds = stones * POUNDS_IN_STONE;
                Console.WriteLine("");
                FeetCalculator();
            }
            else if (choice == "2")
            {
                Console.WriteLine("");
                Console.WriteLine("You have chosen pounds.");
                Console.Write("Enter your weight in pounds > ");
                string weight = Console.ReadLine();
                pounds = Convert.ToDouble(weight);
                Console.WriteLine("");  
                FeetCalculator();
            }
            else 
            {
                Console.WriteLine("You have entered wrong choice number, try again.");
                PoundsCalculator();
            }
        }

        ///prompts user to input their weight in kg.
        private void KGCalculator()
        {
            Console.Write("Enter your weight in KG > ");
            string weight = Console.ReadLine();
            kg = Convert.ToDouble(weight);
            Console.WriteLine("");
            MetresCalculator();
        }

        ///prompts user to choose between feet and inches and to input their height.
        private void FeetCalculator()
        {
            Console.WriteLine("Choose height units: ");
            Console.WriteLine("1. Feet.");
            Console.WriteLine("2. Inches.");
            Console.Write("Enter your choice number > ");
            string choice = Console.ReadLine();
            Console.WriteLine("");
            if(choice == "1")
            {
                Console.WriteLine("You have chosen feet.");
                Console.Write("Enter your height in feet > ");
                string height = Console.ReadLine();
                feet = Convert.ToDouble(height);
                inches = feet * INCHES_IN_FEET;
                Console.WriteLine("");
                BodyMassIndexCalculator();
            }
            else if(choice == "2")
            {
                Console.WriteLine("You have chosen inches.");
                Console.Write("Enter your height in inches > ");
                string height = Console.ReadLine();
                inches = Convert.ToDouble(height);
                Console.WriteLine("");
                BodyMassIndexCalculator();
            }
            else
            {
                Console.WriteLine("You have entered wrong choice number. Try again.");
                FeetCalculator();
            }
        }

        ///prompts user to input their height in metres.
        private void MetresCalculator()
        {
            Console.Write("Enter your height in metres > ");
            string height = Console.ReadLine();
            metres = Convert.ToDouble(height);
            BodyMassIndexCalculator2();
        }

        ///calculates users bmi using pounds and inches.
        private void BodyMassIndexCalculator()
        {
            Console.WriteLine("Your weight is " + pounds + " pounds.");
            Console.WriteLine("Your height is " + inches + " inches.");
            Console.WriteLine("Starting calculating process...");
            index = (pounds * 703) / (inches * inches);
            IndexResult();
        }

        ///calculates users bmi using metres and kg.
        private void BodyMassIndexCalculator2()
        {
            Console.WriteLine("Your weight is " + kg + " kilograms.");
            Console.WriteLine("Your height is " + metres + " metres.");
            Console.WriteLine("Starting calculating process...");
            index = kg / (metres*metres);
            IndexResult();
        }

        ///outputs bmi result with description.
        private void IndexResult()
        {
            Console.WriteLine("Your body mass index was calculated.");
            Console.WriteLine("It is " + index + " kg/m^2");
            if (index <18.5)
            {
                Console.WriteLine("Depending on it, you are underweight. It can cause risks for your health.");
            }
            else if (index < 24.9)
            {
                Console.WriteLine("Your weight status is normal.");
            }
            else if (index < 29.9)
            {
                Console.WriteLine("Depending on it, you are overweight. It can cause risks for your health.");
            }
            else if (index < 34.9)
            {
                Console.WriteLine("Your weight status is Obese Class 1. It can cause serious harm to your health.");
            }
            else if (index < 39.9)
            {
                Console.WriteLine("Your weight status is Obese Class 2. It can cause serious harm to your health");
            }
            else
            {
                Console.WriteLine("Your weight status is Obese Class 3. It can cause serious harm to your health");
            }
            OutputResult();
        }

        ///outputs additional info about bmi.
        private void OutputResult()
        {
            Console.WriteLine("If you are Black, Asian or other minority group, you have a higher risks.");
            Console.WriteLine("Adults 23.0 or more are at increased risk.");
            Console.WriteLine("Adults 27.5 or more are at high risk.");
        }
    }
}
