using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass]
    public class AnimalGroupNameTests
    {
        [TestMethod]
        public void TestAnimalGroupNames()
        {
            AnimalGroupName animal = new AnimalGroupName();
            string[] animalNames = { "rhino", "giraffe", "elephant" };

            Assert.AreEqual("Crash", animal.GetHerd(animalNames[0]));
            Assert.AreEqual("Tower", animal.GetHerd(animalNames[1]));
            Assert.AreEqual("Herd", animal.GetHerd(animalNames[2]));
        }

        [TestMethod]
        public void TestAninmalGroupNamesCapitalization()
        {
            AnimalGroupName animal = new AnimalGroupName();
            string[] animalNames = { "rHiNo", "gIraFfE", "ElePhant" };

            Assert.AreEqual("Crash", animal.GetHerd(animalNames[0]));
            Assert.AreEqual("Tower", animal.GetHerd(animalNames[1]));
            Assert.AreEqual("Herd", animal.GetHerd(animalNames[2]));
        }
        [TestMethod]
        public void TestAnimalGroupNamesForUnknown()
        {
            AnimalGroupName animal = new AnimalGroupName();
            string[] animalNames = { "RhiN", "gaffE", "Elepnt" };

            Assert.AreEqual("unknown", animal.GetHerd(animalNames[0]));
            Assert.AreEqual("unknown", animal.GetHerd(animalNames[1]));
            Assert.AreEqual("unknown", animal.GetHerd(animalNames[2]));
        }
    }
}
