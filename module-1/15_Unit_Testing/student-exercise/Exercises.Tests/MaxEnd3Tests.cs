using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass]
    public class MaxEnd3Tests
    {
        [TestMethod]
        public void TestHappyPathMaxEnd3()
        {
            MaxEnd3 happyPath = new MaxEnd3();
            List<int[]> listOfNums = new List<int[]>
            {
                new int[] { 1, 2, 3 },
                new int[] { 1, 1, 2 },
                new int[] { 2, 6, 3},
                new int[] { 3, 3, 3 },
                new int[] { 2, 2, 2 }
            };

            CollectionAssert.AreEqual(listOfNums[3], happyPath.MakeArray(listOfNums[0]));
            CollectionAssert.AreEqual(listOfNums[4], happyPath.MakeArray(listOfNums[1]));
            CollectionAssert.AreEqual(listOfNums[3], happyPath.MakeArray(listOfNums[2]));
        }
        [TestMethod]
        public void TesthMaxEnd3GivenNull()
        {
            MaxEnd3 happyPath = new MaxEnd3();
            int[] listOfNums = null;

            Assert.AreEqual(null, happyPath.MakeArray(listOfNums));
        }
    }
}
