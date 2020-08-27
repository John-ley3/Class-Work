using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass]
    public class KataPotterTests
    {
        [TestMethod]
        public void BasicPurchaseScenarios()
        {

            // No Books
            Assert.AreEqual(0.0M, new KataPotter().GetCost(new int[] { }));
            Assert.AreEqual(0.0M, new KataPotter().GetCost(new int[] { 0, 0 }));

            // Individual Books
            Assert.AreEqual(8.0M, new KataPotter().GetCost(new int[] { 1 }));
            Assert.AreEqual(8.0M, new KataPotter().GetCost(new int[] { 0, 1 }));
            Assert.AreEqual(8.0M, new KataPotter().GetCost(new int[] { 0, 0, 1 }));
            Assert.AreEqual(8.0M, new KataPotter().GetCost(new int[] { 0, 0, 0, 1 }));
            Assert.AreEqual(8.0M, new KataPotter().GetCost(new int[] { 0, 0, 0, 0, 1 }));

            //// Two or More of the Same
            Assert.AreEqual(8.0M * 2, new KataPotter().GetCost(new int[] { 2 }));
            Assert.AreEqual(8.0M * 3, new KataPotter().GetCost(new int[] { 0, 3 }));
        }

        [TestMethod]
        public void SimpleDiscounts()
        {
            Assert.AreEqual(8.0M * 2 * 0.95M, new KataPotter().GetCost(new int[] { 1, 1 }));
            Assert.AreEqual(8.0M * 3 * 0.90M, new KataPotter().GetCost(new int[] { 1, 1, 1 }));
            Assert.AreEqual(8.0M * 4 * 0.80M, new KataPotter().GetCost(new int[] { 1, 1, 1, 1 }));
            Assert.AreEqual(8.0M * 5 * 0.75M, new KataPotter().GetCost(new int[] { 1, 1, 1, 1, 1 }));
        }
        [TestMethod]
        public void SeveralDiscounts()
        {
            Assert.AreEqual(8.0M + 8.0M * 2 * 0.95M, new KataPotter().GetCost(new int[] { 2, 1, }));
            Assert.AreEqual(8.0M + 8.0M * 3 * 0.90M, new KataPotter().GetCost(new int[] { 2, 1, 1 }));
            Assert.AreEqual(8.0M * 2 * 0.95M + 8.0M * 3 * 0.90M, new KataPotter().GetCost(new int[] { 2, 2, 1 }));
            Assert.AreEqual(8.0M * 4 * 0.80M + 8.0M * 2 * 0.95M, new KataPotter().GetCost(new int[] { 2, 1, 2, 1 }));
        }

        [TestMethod]
        public void ComplexDiscounts()
        {
            Assert.AreEqual(2 * (8.0M * 4 * 0.80M), new KataPotter().GetCost(new int[] { 2, 2, 2, 1, 1 }));
            Assert.AreEqual((8.0M * 5 * 0.75M) + 3 * 8.0M, new KataPotter().GetCost(new int[] { 1, 4, 1, 1, 1 })); //set of 5 + 3 sets of 1
            Assert.AreEqual(3 * (8.0M * 5 * 0.75M) + 2 * (8 * 4 * 0.8M), new KataPotter().GetCost(new int[] { 5, 5, 4, 5, 4 }));
        }

    }
}
