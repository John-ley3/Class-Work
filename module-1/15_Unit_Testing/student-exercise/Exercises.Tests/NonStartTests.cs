using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass]
    public class NonStartTests
    {
        [TestMethod]
        public void TestNonStartHappyPath()
        {
            NonStart strings = new NonStart();
            List<string[]> testStrings = new List<string[]>
            {
                new string[] { "Hello", "There", "ellohere" },
                new string[] { "java", "code", "avaode" },
                new string[] { "shotl", "java", "hotlava" }
            };

            Assert.AreEqual(testStrings[0][2], strings.GetPartialString(testStrings[0][0], testStrings[0][1]));
            Assert.AreEqual(testStrings[1][2], strings.GetPartialString(testStrings[1][0], testStrings[1][1]));
            Assert.AreEqual(testStrings[2][2], strings.GetPartialString(testStrings[2][0], testStrings[2][1]));
        }
        [TestMethod]
        public void TestNonStart0Length()
        {
            NonStart strings = new NonStart();
            string emptyString = "";
            string nonEmptyString = "Hello";

            Assert.AreEqual("ello", strings.GetPartialString(emptyString, nonEmptyString));
            Assert.AreEqual("ello", strings.GetPartialString(nonEmptyString, emptyString));
        }
    }
}
