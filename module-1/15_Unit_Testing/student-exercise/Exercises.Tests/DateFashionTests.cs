using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass]
    public class DateFashionTests
    {
        [TestMethod]
        public void TestAbove8Below2DateFashion()
        {
            DateFashion above8Below2 = new DateFashion();
            int[] yourFashion = { 8, 9, 10, 2 };
            int[] dateFashion = { 2, 1, 0, 10 };

            Assert.AreEqual(0, above8Below2.GetATable(yourFashion[0], dateFashion[0]));
            Assert.AreEqual(0, above8Below2.GetATable(yourFashion[1], dateFashion[1]));
            Assert.AreEqual(0, above8Below2.GetATable(yourFashion[2], dateFashion[2]));
            Assert.AreEqual(0, above8Below2.GetATable(yourFashion[3], dateFashion[3]));
        }

        [TestMethod]
        public void TestAbove8Above2DateFashion()
        {
            DateFashion above8Below2 = new DateFashion();
            int[] yourFashion = { 8, 10, 5 };
            int[] dateFashion = { 5, 3, 10 };

            Assert.AreEqual(2, above8Below2.GetATable(yourFashion[0], dateFashion[0]));
            Assert.AreEqual(2, above8Below2.GetATable(yourFashion[1], dateFashion[1]));
            Assert.AreEqual(2, above8Below2.GetATable(yourFashion[2], dateFashion[2]));
        }

        [TestMethod]
        public void TestBelow8Above2DateFashion()
        {
            DateFashion above8Below2 = new DateFashion();
            int[] yourFashion = { 7, 4, 6 };
            int[] dateFashion = { 4, 3, 6 };

            Assert.AreEqual(1, above8Below2.GetATable(yourFashion[0], dateFashion[0]));
            Assert.AreEqual(1, above8Below2.GetATable(yourFashion[1], dateFashion[1]));
            Assert.AreEqual(1, above8Below2.GetATable(yourFashion[2], dateFashion[2]));
        }
    }
}
