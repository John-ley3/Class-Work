using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass]
    public class Less20Tests
    {
        [TestMethod]
        public void TestLess20_1LessThan20()
        {
            Less20 oneLess = new Less20();
            int[] values = { 19, 39, 59, 79 };

            Assert.AreEqual(true, oneLess.IsLessThanMultipleOf20(values[0]));
            Assert.AreEqual(true, oneLess.IsLessThanMultipleOf20(values[1]));
            Assert.AreEqual(true, oneLess.IsLessThanMultipleOf20(values[2]));
            Assert.AreEqual(true, oneLess.IsLessThanMultipleOf20(values[3]));
        }
        [TestMethod]
        public void TestLess20_2LessThan20()
        {
            Less20 twoLess = new Less20();
            int[] values = { 18, 38, 58, 78 };

            Assert.AreEqual(true, twoLess.IsLessThanMultipleOf20(values[0]));
            Assert.AreEqual(true, twoLess.IsLessThanMultipleOf20(values[1]));
            Assert.AreEqual(true, twoLess.IsLessThanMultipleOf20(values[2]));
            Assert.AreEqual(true, twoLess.IsLessThanMultipleOf20(values[3]));
        }
        [TestMethod]
        public void TestLess20FalseValues()
        {
            Less20 twoLess = new Less20();
            int[] values = { 29, 8, 9, 68 };

            Assert.AreEqual(false, twoLess.IsLessThanMultipleOf20(values[0]));
            Assert.AreEqual(false, twoLess.IsLessThanMultipleOf20(values[1]));
            Assert.AreEqual(false, twoLess.IsLessThanMultipleOf20(values[2]));
            Assert.AreEqual(false, twoLess.IsLessThanMultipleOf20(values[3]));
        }
    }
}
