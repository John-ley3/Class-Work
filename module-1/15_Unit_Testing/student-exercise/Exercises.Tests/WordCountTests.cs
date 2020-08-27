using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass]
    public class WordCountTests
    {
        [TestMethod]
        public void TestWordCountHappyPath()
        {
            WordCount testWordCount = new WordCount();
            Dictionary<string, int> blackSheepStrings = new Dictionary<string, int>
            {
                {"ba", 2},
                {"black", 1},
                {"sheep", 1}
            };
            Dictionary<string, int> abcStrings = new Dictionary<string, int>
            {
                {"a", 2},
                {"b", 2},
                {"c", 1}
            };
            string[] blackSheep = { "ba", "ba", "black", "sheep" };
            string[] abc = { "a", "b", "a", "c", "b" };

            CollectionAssert.AreEqual(blackSheepStrings, testWordCount.GetCount(blackSheep));
            CollectionAssert.AreEqual(abcStrings, testWordCount.GetCount(abc));
        }
        [TestMethod]
        public void TestWordCountGivenNulls()
        {
            WordCount testWordCount = new WordCount();
            Dictionary<string, int> emptyDict = new Dictionary<string, int>();
            string[] emptyArray = null;

            CollectionAssert.AreEqual(emptyDict, testWordCount.GetCount(emptyArray));
        }
    }
}
