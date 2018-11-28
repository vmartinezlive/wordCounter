namespace WordCounter
{
  public class Word
  {
    private string _word;
    private string _sentence;
    public Word(string word, string sentence)
    {
      _word = word;
      _sentence = sentence;
    }
    public string GetWord()
    {
      return _word;
    }
    public string GetSentence()
    {
      return _sentence;
    }
    public bool CompareWord(string word)
    {
      if(_word == word)
      {
        return true;
      }
      return false;
    }
    public int CountWords()
    {
      // change the sentence string into an array of strings
      // for loop or foreach loop to loop through all words in the senctence
      // create variable count to keep track of how many times the word occurs in the sentence
      // use the CompareWord method inside for/foreach loop to compare each word in the sentence to the target word
      return 0; // return count variable 
    }
  }
}
