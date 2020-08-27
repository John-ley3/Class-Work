using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass]
    public class FrontTimesTests
    {
        [TestMethod]
        public void TestHappyPathFrontTimes()
        {
            FrontTimes happyPath = new FrontTimes();
            string[] words = { "Chocolate", "Abc", "No" };
            int[] numOfTimes = { 1, 2, 3 };

            Assert.AreEqual("Cho", happyPath.GenerateString(words[0], numOfTimes[0]));
            Assert.AreEqual("ChoCho", happyPath.GenerateString(words[0], numOfTimes[1]));
            Assert.AreEqual("Abc", happyPath.GenerateString(words[1], numOfTimes[0]));
            Assert.AreEqual("NoNoNo", happyPath.GenerateString(words[2], numOfTimes[2]));
        }
        [TestMethod]
        public void TestBadDataFrontTimes()
        {
            FrontTimes happyPath = new FrontTimes();
            string[] words = { null, "No" };
            int[] numOfTimes = { -1, 0, 1 };

            Assert.AreEqual("", happyPath.GenerateString(words[0], numOfTimes[0]));
            Assert.AreEqual("", happyPath.GenerateString(words[0], numOfTimes[2]));
            Assert.AreEqual("", happyPath.GenerateString(words[1], numOfTimes[1]));
        }
    }
}
