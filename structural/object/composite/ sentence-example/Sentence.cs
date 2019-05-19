using System.Collections.Generic;

namespace practicing_design_patterns.structural.@object.composite.sentence_example
{
  public sealed class Sentence : LetterComposite
  {
    public Sentence(IEnumerable<Word> words)
    {
      foreach (var word in words)
      {
        base.Add(word);
      }
    }
    protected override void PrintThisAfter()
      => SentenceExampleUnitTests.OutputHelper.WriteLine(".");
  }
}