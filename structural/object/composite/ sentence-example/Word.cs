using System.Collections.Generic;

namespace practicing_design_patterns.structural.@object.composite.sentence_example
{
  public sealed class Word : LetterComposite
  {
    public Word(IEnumerable<Letter> letters)
    {
      foreach (var chr in letters)
      {
        base.Add(chr);
      }
    }
    protected override void PrintThisBefore()
      => SentenceExampleUnitTests.OutputHelper.WriteLine(" ");
  }
}