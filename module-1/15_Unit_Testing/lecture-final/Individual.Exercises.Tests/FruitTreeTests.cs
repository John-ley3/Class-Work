using Individual.Exercises.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Individual.Exercises.Tests
{
    [TestClass]
    public class FruitTreeTests
    {
        [TestMethod]
        public void CheckConstructor()
        {
            // Arrange
            string nameOfFruit = "Pineapple";
            int startingPiecesOfFruit = 1;
            FruitTree pineappleTree;

            // Act
            pineappleTree = new FruitTree(nameOfFruit, startingPiecesOfFruit);

            // Assert
            Assert.AreEqual(nameOfFruit, pineappleTree.TypeOfFruit, "I didn't get Pineapple");
            Assert.AreEqual(startingPiecesOfFruit, pineappleTree.PiecesOfFruitLeft);
        }

        [TestMethod]
        public void CheckConstructorNullName()
        {
            // Arrange
            string nameOfFruit = null;
            int startingPiecesOfFruit = 1;
            FruitTree pineappleTree;

            // Act
            pineappleTree = new FruitTree(nameOfFruit, startingPiecesOfFruit);

            // Assert
            Assert.AreEqual(nameOfFruit, pineappleTree.TypeOfFruit, "I didn't get Pineapple");

        }

        [TestMethod]
        public void TestHappyPathPickFruit()
        {
            // Arrange
            FruitTree appleTree = new FruitTree("Apple", 25);
            int numberOfApplesToPick = 10;
            int numberOfApplesLeft = 15;

            // Act
            bool didPickFruit = appleTree.PickFruit(numberOfApplesToPick);

            // Assert
            Assert.AreEqual(numberOfApplesLeft, appleTree.PiecesOfFruitLeft);
        }

        [TestMethod]
        public void TestHappyPathPickFruitReturn()
        {
            // Arrange
            FruitTree appleTree = new FruitTree("Apple", 25);
            int numberOfApplesToPick = 10;

            // Act
            bool didPickFruit = appleTree.PickFruit(numberOfApplesToPick);

            // Assert
            Assert.IsTrue(didPickFruit);
        }

        [TestMethod]
        public void TestPickNegativeFruit()
        {
            // Arrange
            FruitTree appleTree = new FruitTree("Apple", 25);
            int numberOfApplesToPick = -10;

            // Act
            bool didPickFruit = appleTree.PickFruit(numberOfApplesToPick);

            // Assert
            Assert.IsFalse(didPickFruit, "I passed in -10 pieces and shouldn't be able to pick them");
        }

        [TestMethod]
        public void TestSillyArray()
        {
            // Arrange
            FruitTree pear = new FruitTree("Pear", 42);
            int[] expected = new int[2] { 8, 42 };

            // Act
            int[] output = pear.TreeData(8);

            // Assert
            CollectionAssert.AreEqual(expected, output);
        }
    }
}
