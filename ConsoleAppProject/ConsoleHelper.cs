using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppProject
{
    public static class ConsoleHelper
    {
        ///<summary>
        ///This method displays a list of numbered choices to the
        ///user, and they can select the choice number is returned.
        ///</summary>
        public static int SelectChoice(string[] choices)
        {
            ///Display all the choices.

            int choiceNo = 0;

            foreach (string choice in choices)
            {
                choiceNo++;
                Console.WriteLine($"     {choiceNo}.   {choice}");
            }

            ///Get the users choice.

            return 0;
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
            Console.WriteLine("Select distance unit to convert from:");
            Console.WriteLine("1: Miles");
            Console.WriteLine("2: Feet");
            Console.WriteLine("3: Metres");
        }
    }
}
