using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using WordCounter;

namespace WordCounter.Tests
{
  [TestClass]
  public class WordTest
  {
    [TestMethod]
    public void Constructor_SetsWordAndSentence_True()
    {
      // Arrange
      string testSentence = "I took apple from the appletree";
      string testWord = "apple";
      Word newWord = new Word(testWord, testSentence);
      Assert.AreEqual("apple", newWord.GetWord());
      Assert.AreEqual("I took apple from the appletree", newWord.GetSentence());
    }

    [TestMethod]
    public void CompareWord_ChecksIfWordsAreTheSame_True()
    {
      string testSentence = "I took apple from the appletree";
      string testWord = "apple";
      Word newWord = new Word(testWord, testSentence);
      bool actualResult = newWord.CompareWord("apple");
      bool expectedResult = true;
      Assert.AreEqual(expectedResult, actualResult);
    }

    [TestMethod]
    public void CountWords_ReturNumberOfTimesWordsIsFound_1()
    {
      // Arrange (create variables used by the class we're testing)
      string testSentence = "I took apple from the appletree";
      string testWord = "apple";
      Word newWord = new Word(testWord, testSentence);
      int expectedResult = 1;
      // Act (call the method that you're testing)
      int actualResult = newWord.CountWords();
      // Assert (compare the expected value with the actual value)
      Assert.AreEqual(expectedResult, actualResult);
    }

  }
}
