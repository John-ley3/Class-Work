using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using TDDRoman.Classes;

namespace TDDRomanTests.Classes
{
    [TestClass]
    public class RomanNumeralTests
    {
        RomanNumeral romanNumeral { get; set; }
        [TestInitialize]
        public void SetThingsUp()
        {
            romanNumeral = new RomanNumeral();
        }
        [TestMethod]
        public void RomanNumeral_Ones()
        {
            // Assert
            Assert.AreEqual("I", romanNumeral.GetRomanNumeral(1));
            Assert.AreEqual("II", romanNumeral.GetRomanNumeral(2));
            Assert.AreEqual("III", romanNumeral.GetRomanNumeral(3));
            Assert.AreEqual("IV", romanNumeral.GetRomanNumeral(4));
        }
        [TestMethod]
        public void RomanNumeral_Fives()
        {
            Assert.AreEqual("V", romanNumeral.GetRomanNumeral(5));
            Assert.AreEqual("VI", romanNumeral.GetRomanNumeral(6));
            Assert.AreEqual("VII", romanNumeral.GetRomanNumeral(7));
            Assert.AreEqual("VIII", romanNumeral.GetRomanNumeral(8));
        }

        [TestMethod]
        public void RomanNumeral_Tens()
        {
            Assert.AreEqual("X", romanNumeral.GetRomanNumeral(10));
            Assert.AreEqual("XI", romanNumeral.GetRomanNumeral(11));
            Assert.AreEqual("XV", romanNumeral.GetRomanNumeral(15));
            Assert.AreEqual("XVIII", romanNumeral.GetRomanNumeral(18));
        }
        [TestMethod]
        public void RomanNumeral_Fifites()
        {
            Assert.AreEqual("L", romanNumeral.GetRomanNumeral(50));
            Assert.AreEqual("LIII", romanNumeral.GetRomanNumeral(53));
            Assert.AreEqual("LVIII", romanNumeral.GetRomanNumeral(58));
            Assert.AreEqual("LV", romanNumeral.GetRomanNumeral(55));
            Assert.AreEqual("LI", romanNumeral.GetRomanNumeral(51));

        }
        [TestMethod]
        public void RomanNumeral_Hundreds()
        {
            Assert.AreEqual("C", romanNumeral.GetRomanNumeral(100));
            Assert.AreEqual("CLIII", romanNumeral.GetRomanNumeral(153));
            Assert.AreEqual("CXXXVII", romanNumeral.GetRomanNumeral(137));
            Assert.AreEqual("CI", romanNumeral.GetRomanNumeral(101));
            Assert.AreEqual("CLXXXII", romanNumeral.GetRomanNumeral(182));

        }
        [TestMethod]
        public void RomanNumeral_FiveHundreds()
        {
            Assert.AreEqual("D", romanNumeral.GetRomanNumeral(500));
            Assert.AreEqual("DLXXXIII", romanNumeral.GetRomanNumeral(583));
            Assert.AreEqual("DXXII", romanNumeral.GetRomanNumeral(522));
            Assert.AreEqual("DXIII", romanNumeral.GetRomanNumeral(513));
            Assert.AreEqual("DCCCLXXXVIII", romanNumeral.GetRomanNumeral(888));

        }
        [TestMethod]
        public void RomanNumeral_Thousands()
        {
            Assert.AreEqual("M", romanNumeral.GetRomanNumeral(1000));
            Assert.AreEqual("MDCLVIII", romanNumeral.GetRomanNumeral(1658));
            Assert.AreEqual("MMI", romanNumeral.GetRomanNumeral(2001));
            Assert.AreEqual("MMDCCCXXXII", romanNumeral.GetRomanNumeral(2832));

        }
        [TestMethod]
        public void RomanNumeral_Subtractive()
        {
            Assert.AreEqual("IV", romanNumeral.GetRomanNumeral(4));
            Assert.AreEqual("XIV", romanNumeral.GetRomanNumeral(14));
            Assert.AreEqual("XXIV", romanNumeral.GetRomanNumeral(24));

            Assert.AreEqual("IX", romanNumeral.GetRomanNumeral(9));
            Assert.AreEqual("XXIX", romanNumeral.GetRomanNumeral(29));
            Assert.AreEqual("LIX", romanNumeral.GetRomanNumeral(59));

            Assert.AreEqual("XL", romanNumeral.GetRomanNumeral(40));
            Assert.AreEqual("XLIX", romanNumeral.GetRomanNumeral(49));
            Assert.AreEqual("XLIV", romanNumeral.GetRomanNumeral(44));

            Assert.AreEqual("CD", romanNumeral.GetRomanNumeral(400));
            Assert.AreEqual("XC", romanNumeral.GetRomanNumeral(90));
            Assert.AreEqual("CM", romanNumeral.GetRomanNumeral(900));

        }

        [TestMethod]
        public void RomanNumeral_Random()
        {
            Assert.AreEqual("MIV", romanNumeral.GetRomanNumeral(1004));
            Assert.AreEqual("DIV", romanNumeral.GetRomanNumeral(504));
            Assert.AreEqual("CDLXII", romanNumeral.GetRomanNumeral(462));
            Assert.AreEqual("CDXCIX", romanNumeral.GetRomanNumeral(499));
            Assert.AreEqual("XLI", romanNumeral.GetRomanNumeral(41));
            Assert.AreEqual("XCV", romanNumeral.GetRomanNumeral(95));
        }

        [TestMethod]
        public void RomanNumeral_Boundries()
        {
            Assert.AreEqual("MMCMXCIX", romanNumeral.GetRomanNumeral(2999));
        }

        [TestMethod]
        public void RomanNumeral_OutOfBounds()
        {
            Assert.AreEqual("", romanNumeral.GetRomanNumeral(0));
            Assert.AreEqual("", romanNumeral.GetRomanNumeral(-8));
            Assert.AreEqual("", romanNumeral.GetRomanNumeral(4561));
        }
    }
}
