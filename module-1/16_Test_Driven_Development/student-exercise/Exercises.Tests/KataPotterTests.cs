using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class KataPotterTests
    {
        KataPotter PotterBooks { get; set; }

        [TestInitialize]
        public void Setup()
        {
            KataPotter PotterBooks = new KataPotter();
        }
        
        [TestMethod]
        public void ReturnsLowestCostHappyPath()
        {
            Assert.AreEqual(5120M, PotterBooks.GetCost(new int[] { 2, 2, 2, 1, 1 }));
        }
    }
}
