using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Tests
{
    [TestClass()]
    public class KataFizzBuzzTests
    {
        KataFizzBuzz FizzBuzz { get; set; }
        [TestInitialize]
        public void Setup()
        {
            FizzBuzz = new KataFizzBuzz();
        }
        
        [TestMethod]
        public void NumberDivisableBy3IsFizz()
        {
            Assert.AreEqual("Fizz", FizzBuzz.GetFizzBuzz(3));
            Assert.AreEqual("Fizz", FizzBuzz.GetFizzBuzz(9));
            Assert.AreEqual("Fizz", FizzBuzz.GetFizzBuzz(12));
            Assert.AreEqual("Fizz", FizzBuzz.GetFizzBuzz(21));
        }
        [TestMethod]
        public void NumberDivisableBy5IsBuzz()
        {
            Assert.AreEqual("Buzz", FizzBuzz.GetFizzBuzz(5));
            Assert.AreEqual("Buzz", FizzBuzz.GetFizzBuzz(10));
            Assert.AreEqual("Buzz", FizzBuzz.GetFizzBuzz(40));
            Assert.AreEqual("Buzz", FizzBuzz.GetFizzBuzz(65));
        }
        [TestMethod]
        public void NumberDivisableBy5and3IsFizzBuzz()
        {
            Assert.AreEqual("FizzBuzz", FizzBuzz.GetFizzBuzz(15));
            Assert.AreEqual("FizzBuzz", FizzBuzz.GetFizzBuzz(30));
            Assert.AreEqual("FizzBuzz", FizzBuzz.GetFizzBuzz(60));
            Assert.AreEqual("FizzBuzz", FizzBuzz.GetFizzBuzz(90));
        }
        [TestMethod]
        public void TestNonMultiplesOf3and5LessThan100()
        {
            Assert.AreEqual("1", FizzBuzz.GetFizzBuzz(1));
            Assert.AreEqual("7", FizzBuzz.GetFizzBuzz(7));
            Assert.AreEqual("14", FizzBuzz.GetFizzBuzz(14));
            Assert.AreEqual("8", FizzBuzz.GetFizzBuzz(8));
        }
        [TestMethod]
        public void TestNumbersGreaterThan100()
        {
            Assert.AreEqual("", FizzBuzz.GetFizzBuzz(200));
            Assert.AreEqual("", FizzBuzz.GetFizzBuzz(700));
            Assert.AreEqual("", FizzBuzz.GetFizzBuzz(900));
            Assert.AreEqual("", FizzBuzz.GetFizzBuzz(1200));
        }
        [TestMethod]
        public void TestNumbersLessThanOrEqual0()
        {
            Assert.AreEqual("", FizzBuzz.GetFizzBuzz(0));
            Assert.AreEqual("", FizzBuzz.GetFizzBuzz(-700));
            Assert.AreEqual("", FizzBuzz.GetFizzBuzz(-300));
            Assert.AreEqual("", FizzBuzz.GetFizzBuzz(-20));
        }
        [TestMethod]
        public void Divisableby3OrContains3()
        {
            Assert.AreEqual("Fizz", FizzBuzz.GetFizzBuzz(13));
            Assert.AreEqual("Fizz", FizzBuzz.GetFizzBuzz(23));
            Assert.AreEqual("Fizz", FizzBuzz.GetFizzBuzz(13));
            Assert.AreEqual("Fizz", FizzBuzz.GetFizzBuzz(12));
        }
        [TestMethod]
        public void DivisableBy5orContains5()
        {
            Assert.AreEqual("Buzz", FizzBuzz.GetFizzBuzz(5));
            Assert.AreEqual("Buzz", FizzBuzz.GetFizzBuzz(56));
            Assert.AreEqual("Buzz", FizzBuzz.GetFizzBuzz(52));
            Assert.AreEqual("Buzz", FizzBuzz.GetFizzBuzz(50));
        }
        [TestMethod]
        public void NumberContainsOrIsDivisableBy5and3()
        {
            Assert.AreEqual("FizzBuzz", FizzBuzz.GetFizzBuzz(15));
            Assert.AreEqual("FizzBuzz", FizzBuzz.GetFizzBuzz(35));
            Assert.AreEqual("FizzBuzz", FizzBuzz.GetFizzBuzz(53));
            Assert.AreEqual("FizzBuzz", FizzBuzz.GetFizzBuzz(90));
        }
    }
}
