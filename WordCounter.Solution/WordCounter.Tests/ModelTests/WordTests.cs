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
    public void GetNumberOfWord_HowManyWordInSentence_One()
    {
      GetNumberOfWord testGetNumberOfWord = new GetNumberOfWord();
      Assert.AreEqual(WordTest.GetNumberOfWord(One));
    }

    [TestMethod]
    public void SearchForWord_SearchForDuplicateWord();
    {
      Assert.AreEqual(WordTest.SearchForWord());
    }


  }
}
