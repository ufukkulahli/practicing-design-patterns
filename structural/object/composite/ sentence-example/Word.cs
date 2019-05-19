namespace practicing_design_patterns.structural.@object.composite.sentence_example
{
  public sealed class Word : LetterComposite
  {
    protected override void PrintThisBefore()
      => SentenceExampleUnitTests.OutputHelper.WriteLine(" ");
  }
}