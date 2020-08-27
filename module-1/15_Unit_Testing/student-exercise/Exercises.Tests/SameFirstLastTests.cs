using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass]
    public class SameFirstLastTests
    {
        [TestMethod]
        public void TestSameFirstLastHappyPath()
        {
            SameFirstLast happyPath = new SameFirstLast();
            List<int[]> numArrays = new List<int[]>
            {
                new int[] { 1, 2, 3, 1 },
                new int[] { 2, 3, 1, 2}
            };

            Assert.IsTrue(happyPath.IsItTheSame(numArrays[0]));
            Assert.IsTrue(happyPath.IsItTheSame(numArrays[1]));
        }
        [TestMethod]
        public void TestSameFirstLastGivenNulls()
        {
            SameFirstLast empty = new SameFirstLast();
            int[] emptyArray = null;

            Assert.IsFalse(empty.IsItTheSame(emptyArray));
        }
    }
}
