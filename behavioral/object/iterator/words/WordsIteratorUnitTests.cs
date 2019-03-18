using Xunit;

namespace practicing_design_patterns.behavioral.@object.iterator.words
{
  public class WordsIteratorUnitTests
  {
    [Fact]
    public void TestThatShouldIterateOverWordsOfSentence()
    {
      // Arrange
      IAggregate<string> sentence = new Sentence("Lorem ipsum dolor sit");
      IIterator<string> sentenceIterator = sentence.CreateIterator();
      
      // Act & Assert
      Assert.True(sentenceIterator.HasNext());
      Assert.Equal("Lorem", sentenceIterator.Next());
      Assert.True(sentenceIterator.HasNext());
      Assert.Equal("ipsum", sentenceIterator.Next());
      Assert.True(sentenceIterator.HasNext());
      Assert.Equal("dolor", sentenceIterator.Next());
      Assert.True(sentenceIterator.HasNext());
      Assert.Equal("sit", sentenceIterator.Next());
      Assert.False(sentenceIterator.HasNext());
    }
  }
}