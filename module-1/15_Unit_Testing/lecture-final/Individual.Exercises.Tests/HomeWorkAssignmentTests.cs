using Individual.Exercises.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Individual.Exercises.Tests
{
    [TestClass]
    public class HomeWorkAssignmentTests
    {
        [DataTestMethod]
        [DataRow(int.MaxValue,"A")]
        [DataRow(-110,"F")]
        [DataRow(70,"C")]
        [DataRow(98,"A")]
        [DataRow(87,"B")]
        [DataRow(75,"C")]
        [DataRow(63,"D")]
        [DataRow(56,"F")]
        public void ScoringAssignment(int scoreReceived,string expectedGrade)
        {
            // Assert
            HomeworkAssignment ha = new HomeworkAssignment(100, "Henry Edwards");

            // Act
            ha.TotalMarks = scoreReceived;

            // Assert
            Assert.AreEqual(expectedGrade, ha.LetterGrade);
        }
    }
}
