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
        //Constants
        public const int LowestMark = 0;
        public const int HighestMark = 100;

        public const int LowestGradeD = 40;
        public const int LowestGradeC = 50;
        public const int LowestGradeB = 60;
        public const int LowestGradeA = 70;

        //Properties
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
        /// Runs the program.
        /// </summary>
        public void Run()
        {
            OutputHeading();
            ChooseMethod();
        }

        /// <summary>
        /// Outputs heading of an App.
        /// </summary>
        private void OutputHeading()
        {
            Console.WriteLine("Student Grades App");
            Console.WriteLine("Choose what you want to do: ");
            Console.WriteLine("1. Input Marks");
            Console.WriteLine("2. Output Marks");
            Console.WriteLine("3. Calculate Mean, Maximum and Minimum marks.");
            Console.WriteLine("4. Calculate and Output Grade Profile.");
            Console.Write("Choose option > ");
        }

        private void ChooseMethod()
        {
            string value = Console.ReadLine();
            Console.WriteLine();
            if (value == "1")
            {
                InputMarks();
            }
            else if (value == "2")
            {
                OutputMarks();
            }
            else if (value == "3")
            {
                CalculateStats();
            }
            else if (value == "4")
            {
                CalculateGradeProfile();
            }
            else Console.Write("Wrong choice number, try again > ");
            ChooseMethod();
        }

        /// <summary>
        /// Input a mark between 0-100 for each student
        /// and store it in Marks array.
        /// </summary>
        public void InputMarks()
        {
            for (int i = 0; i <= Marks.Length; i++)
            {
                Console.Write(Students[i] + " mark > ");
                string value = Console.ReadLine();
                int mark = Convert.ToInt32(value);
                Marks[i] = mark;
                Console.WriteLine();
            }
        }

        /// <summary>
        /// List all the students and display their name
        /// and current mark.
        /// </summary>
        public void OutputMarks()
        {
            for (int i = 0; i < Marks.Length; i++)
            {
                Console.WriteLine(Students[i] + " has mark " + Marks[i]);
                int mark = Marks[i];
                Console.Write("Grade : ");
                ConvertToGrade(mark);
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Convert a student mark to a grade
        /// from F - fail to A - first class.
        /// </summary>
        public Grades ConvertToGrade(int mark)
        {
            if (mark >= LowestMark && mark < LowestGradeD)
            {
                return Grades.F;
            }
            else if (mark >= LowestGradeD && mark < LowestGradeC)
            {
                return Grades.D;
            }
            else if (mark >= LowestGradeC && mark < LowestGradeB)
            {
                return Grades.C;
            }
            else if (mark >= LowestGradeB && mark < LowestGradeA)
            {
                return Grades.B;
            }
            else if (mark >= LowestGradeA && mark <= HighestMark)
            {
                return Grades.A;
            }
            else return 0;
        }

        /// <summary>
        /// Calculate and display minimum,
        /// maximum and mean mark for all the students.
        /// </summary>
        public void CalculateStats()
        {
            Minimum = Marks[0];
            Maximum = Marks[0];
            double total = 0;
         
            foreach(int mark in Marks)
            {
                if (mark < Minimum) Minimum = mark;
                if (mark > Maximum) Maximum = mark;
                total = total + mark;
            }

            Mean = total / Marks.Length;
        }

        /// <summary>
        /// Calculates gradeprofile and toggles output of it.
        /// </summary>
        public void CalculateGradeProfile()
        {
            for(int i = 0; i<GradeProfile.Length; i++)
            {
                GradeProfile[i] = 0;
            }

            foreach(int mark in Marks)
            {
                Grades grade = ConvertToGrade(mark);
                GradeProfile[(int)grade]++;
            }
            OutputGradeProfile();
        }

        private void OutputGradeProfile()
        {
            Grades grade = Grades.A;
            Console.WriteLine();

            foreach(int count in GradeProfile)
            {
                int percentage = count * 100 / Marks.Length;
                Console.WriteLine($"Grade {grade} {percentage}% Count {count}");
                grade++;
            }

            Console.WriteLine();
        }
    }
}
