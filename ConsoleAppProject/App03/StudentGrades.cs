using System;
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

        /// <summary>
        /// Input a mark between 0-100 for each student
        /// and store it in Marks array.
        /// </summary>
        public void InputMarks()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// List all the students and display their name
        /// and current mark.
        /// </summary>
        public void OutputMarks()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Convert a student mark to a grade
        /// from F - fail to A - first class.
        /// </summary>
        public Grades ConvertToGrade(int mark)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Calculate and display minimum,
        /// maximum and mean mark for all the students.
        /// </summary>
        public void CalculateStats()
        {
            throw new NotImplementedException();
        }
    }
}
