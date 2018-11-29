using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using WordCounter.Models;

namespace WordCounter.Tests
{
  [TestClass]
  public class WordTest
  {
    [TestMethod]
    public void WordConstructor_CreatesInstanceOfWord_Word()
    {
      //Arrange
      string word = "apple";
      string sentence = "I ate an apple from appletree";
      Word testWord = new Word(Word);

      //Act and Assert
      Assert.AreEqual(typeof(Word), testWord.GetType());
    }



  }
}
