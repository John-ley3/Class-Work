using Individual.Exercises.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Individual.Exercises.Tests
{
    [TestClass]
    public class TelevisionTests
    {
        [TestMethod]
        public void TurnOnTV_ShouldSetProperties()
        {
            // Arrange
            Television television = new Television();

            // Act
            television.TurnOn();

            // Assert
            Assert.IsTrue(television.IsOn, "Hey, the television didn't turn on");
            Assert.AreEqual(2, television.CurrentVolume);
        }

        [TestMethod]
        public void ChannelUP_HappyPath()
        {
            // Arrange
            Television television = new Television();
            int currentChannel;
            television.TurnOn();
            currentChannel = television.CurrentChannel;

            // Act
            television.ChannelUp();

            // Assert
            Assert.AreEqual(++currentChannel, television.CurrentChannel);
        }

        [TestMethod]
        public void SetChannelAbove18()
        {
            // Arrange
            Television tv = new Television();
            tv.TurnOn();
            int currentChannel = tv.CurrentChannel;

            // Act
            tv.ChangeChannel(19);

            // Assert
            Assert.AreEqual(currentChannel, tv.CurrentChannel);

        }

    }
}
