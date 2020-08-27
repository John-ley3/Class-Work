using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass]
    public class CigarPartyTests
    {
        [TestMethod]
        public void TestWeekdayCigarParty()
        {
            CigarParty weekdayParty = new CigarParty();
            bool isWeekend = false;
            int[] numOfCigars = { 44, 55, 30, 22, 99 };

            Assert.IsTrue(weekdayParty.HaveParty(numOfCigars[0], isWeekend));
            Assert.IsTrue(weekdayParty.HaveParty(numOfCigars[1], isWeekend));
            Assert.IsFalse(weekdayParty.HaveParty(numOfCigars[2], isWeekend));
            Assert.IsFalse(weekdayParty.HaveParty(numOfCigars[3], isWeekend));
            Assert.IsFalse(weekdayParty.HaveParty(numOfCigars[4], isWeekend));
        }
        [TestMethod]
        public void TestWeekendCigarParty()
        {
            CigarParty weekdayParty = new CigarParty();
            bool isWeekend = true;
            int[] numOfCigars = { 44, 55, 30, 22, 99 };

            Assert.IsTrue(weekdayParty.HaveParty(numOfCigars[0], isWeekend));
            Assert.IsTrue(weekdayParty.HaveParty(numOfCigars[1], isWeekend));
            Assert.IsFalse(weekdayParty.HaveParty(numOfCigars[2], isWeekend));
            Assert.IsFalse(weekdayParty.HaveParty(numOfCigars[3], isWeekend));
            Assert.IsTrue(weekdayParty.HaveParty(numOfCigars[4], isWeekend));
        }
        [TestMethod]
        public void TestWeekdayCigarPartyBounds()
        {
            CigarParty weekdayParty = new CigarParty();
            bool isWeekend = false;
            int[] numOfCigars = { 39, 40, 60, 61 };

            Assert.IsFalse(weekdayParty.HaveParty(numOfCigars[0], isWeekend));
            Assert.IsTrue(weekdayParty.HaveParty(numOfCigars[1], isWeekend));
            Assert.IsTrue(weekdayParty.HaveParty(numOfCigars[2], isWeekend));
            Assert.IsFalse(weekdayParty.HaveParty(numOfCigars[3], isWeekend));
        }
        [TestMethod]
        public void TestWeekendCigarPartyBounds()
        {
            CigarParty weekdayParty = new CigarParty();
            bool isWeekend = true;
            int[] numOfCigars = { 39, 40, 999999 };

            Assert.IsFalse(weekdayParty.HaveParty(numOfCigars[0], isWeekend));
            Assert.IsTrue(weekdayParty.HaveParty(numOfCigars[1], isWeekend));
            Assert.IsTrue(weekdayParty.HaveParty(numOfCigars[2], isWeekend));
        }
    }
}
