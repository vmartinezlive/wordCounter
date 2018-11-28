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
    public void GetNumberOfWord_HowManyWordInSentence_2("I took apple from the appletree");
    {
      GetNumberOfWord testGetNumberOfWord = new GetNumberOfWord(2);
      Assert.AreEqual(WordTest.GetNumberOfWord(2));
    }

    [TestMethod]
    public void SearchForWord_SearchForDuplicateWord();
    {
      Assert.AreEqual(WordTest.SearchForWord());
    }

    [TestMethod]
    public void RemoveWord_RemoveDuplicateWord();
    {
      Assert.AreEqual(WordTest.RemoveWord());
    }

  }
}
