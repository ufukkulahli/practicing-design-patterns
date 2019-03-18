namespace practicing_design_patterns.behavioral.@object.iterator.words
{
  public class Sentence : IAggregate<string>
  {
    private string[] words { get; }

    public Sentence(string sentence)
    {
      this.words = Rgex.SplitWords(sentence);
    }

    public IIterator<string> CreateIterator()
    {
      return new WordsIterator(this);
    }

    private sealed class WordsIterator : IIterator<string>
    {
      private int index;
      private readonly Sentence sentence;

      public WordsIterator(Sentence sentence)
      {
        this.sentence = sentence;
        this.index = 0;
      }

      public bool HasNext()
      {
        return this.sentence.words.Length > this.index;
      }

      public string Next()
      {
        throw new System.NotImplementedException();
      }
    }
  }
}