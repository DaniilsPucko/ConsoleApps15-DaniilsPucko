using ConsoleAppProject.App01;
using ConsoleAppProject.App02;
using ConsoleAppProject.App03;
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

        private static StudentGrades grades = new StudentGrades();

        public static void Main()
        {
            Console.WriteLine("Welcome to ConsoleApp");
            Console.WriteLine("MADE BY: DANIILS PUCKO");
            Console.WriteLine("Choose what app you want to use: ");
            ChoiceSelector();
        }
        
        public static void ChoiceSelector()
        {
            Console.WriteLine("1. DISTANCE CONVERTER");
            Console.WriteLine("2. BODY MASS INDEX CALCULATOR");
            Console.WriteLine("3. STUDENT GRADES APPLICATION");
            Console.Write("Make your choice: ");
            string value = Console.ReadLine();
            if (value == "1")
            {
                converter.Run();
            }
            else if (value == "2")
            {
                calculator.Run();
            }
            else if (value =="3")
            {
                grades.Run();
            }
        }
    }
}
