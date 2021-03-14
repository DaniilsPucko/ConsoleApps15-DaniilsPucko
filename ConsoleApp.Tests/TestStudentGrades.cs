﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppProject.App03;

namespace ConsoleApp.Tests
{
    [TestClass]
    public class TestStudentGrades
    {
        private readonly StudentGrades converter = new StudentGrades();

        [TestMethod]
        private void TestCovert0ToGradeF()
        {
            //Arrange

            Grades expectedGrade = Grades.F;

            //Act

            Grades actualGrade = converter.ConvertToGrade(0);

            //Assert

            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        private void TestCovert40ToGradeD()
        {
            //Arrange

            Grades expectedGrade = Grades.D;

            //Act

            Grades actualGrade = converter.ConvertToGrade(40);

            //Assert

            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        private void TestCovert50ToGradeC()
        {
            //Arrange

            Grades expectedGrade = Grades.C;

            //Act

            Grades actualGrade = converter.ConvertToGrade(50);

            //Assert

            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        private void TestCovert60ToGradeB()
        {
            //Arrange

            Grades expectedGrade = Grades.B;

            //Act

            Grades actualGrade = converter.ConvertToGrade(60);

            //Assert

            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        private void TestCovert70ToGradeA()
        {
            //Arrange

            Grades expectedGrade = Grades.A;

            //Act

            Grades actualGrade = converter.ConvertToGrade(70);

            //Assert

            Assert.AreEqual(expectedGrade, actualGrade);
        }


    }
}
