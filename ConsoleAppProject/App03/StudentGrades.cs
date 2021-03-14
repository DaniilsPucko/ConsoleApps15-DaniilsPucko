﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppProject.App03
{
    /// <summary>
    /// Class, which defines methods for giving marks and grades to students.
    /// </summary>
    public class StudentGrades
    {
        public string[] Students { get; set; }

        public int[] Marks { get; set; }

        public int[] GradeProfile { get; set; }

        public double Mean { get; set; }

        public int Minimum { get; set; }

        public int Maximum { get; set; }

        /// <summary>
        /// constructor 
        /// </summary>
        public StudentGrades()
        {
            Students = new string[]
            {
                "Daniel", "German", "Hanzo", "Max",
                "Hatori", "Kayla", "Victor", "Lane",
                "Natalie", "Arthur"
            };

            GradeProfile = new int[(int)Grades.A + 1];
            Marks = new int[Students.Length];

        }
    }
}
