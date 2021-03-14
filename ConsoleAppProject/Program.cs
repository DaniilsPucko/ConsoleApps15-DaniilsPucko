using ConsoleAppProject.App01;
using ConsoleAppProject.App02;
using System;

namespace ConsoleAppProject
{
    /// <summary>
    /// The main method in this class is called first
    /// when the application is started.  It will be used
    /// to start Apps 01 to 05 for CO453 CW1
    /// 
    /// This Project has been modified by:
    /// Daniils Pucko 07.02.2021
    /// </summary>
    public static class Program
    {
        private static DistanceConverter converter = new DistanceConverter();

        private static BMI calculator = new BMI();

        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            ConsoleHelper.OutputHeading("BNU CO453 Applications Programming 2020-2021!");

            string[] choices = { "Distance Converter", "BMI Calculator" };
            ConsoleHelper.SelectChoice(choices);

            Console.WriteLine();
            Console.Beep();

            Console.Write("Please enter your choice of app > ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                converter.ChooseConverter();
            }
            else if (choice == "2")
            {
                calculator.ChooseUnits();
            }

        }
    }
}
