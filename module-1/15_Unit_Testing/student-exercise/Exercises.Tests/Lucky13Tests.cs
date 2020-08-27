using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass]
    public class Lucky13Tests
    {
        [TestMethod]
        public void TestDoesNotContainOneOrThree()
        {
            Lucky13 values = new Lucky13();
            int[] nums = { 2, 4, 6, 9, 21, 33, 299 };

            Assert.IsTrue(values.GetLucky(nums));
        }
        [TestMethod]
        public void TestDoesContainOneOrThree()
        {
            Lucky13 values = new Lucky13();
            int[] nums = { 1, 4, 6, 3, 21, 64, 329 };

            Assert.IsFalse(values.GetLucky(nums));
        }
        [TestMethod]
        public void TestEmptyArray()
        {
            Lucky13 values = new Lucky13();
            int[] nums = null;

            Assert.IsFalse(values.GetLucky(nums));
        }

    }
}
