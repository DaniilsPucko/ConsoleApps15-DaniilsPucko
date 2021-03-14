using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppProject
{
    public static class ConsoleHelper
    {
        public static App01.DistanceConverter DistanceConverter
        {
            get => default;
            set
            {
            }
        }

        ///<summary>
        ///This method displays a list of numbered choices to the
        ///user, and they can select the choice number is returned.
        ///</summary>
        public static int SelectChoice(string[] choices)
        { 
            DisplayChoices(choices);
            Console.Write("Please enter your choice > ");
            string value = Console.ReadLine();
            int choiceNo = Convert.ToInt32(value);
            return 0;
        }

        /// <summary>
        /// Displays choices.
        /// </summary>
        /// <param name="choices"></param>
        private static void DisplayChoices(string[] choices)
        {
            int choiceNo = 0;

            foreach (string choice in choices)
            {
                choiceNo++;
                Console.WriteLine($"     {choiceNo}.   {choice}");
            }
        }


        /// <summary>
        /// Outputs heading of program and choices of converter.
        /// </summary>
        public static void OutputHeading(string title)
        {
            Console.WriteLine("\n----------------------------------");
            Console.WriteLine($"               {title}              ");
            Console.WriteLine("          by Daniils Pucko          ");
            Console.WriteLine("----------------------------------\n");
        }
    }
}
