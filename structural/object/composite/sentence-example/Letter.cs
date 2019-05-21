namespace practicing_design_patterns.structural.@object.composite.sentence_example
{
  public sealed class Letter : LetterComposite
  {
    private readonly char c;
    public Letter(char c) => this.c = c;
    protected override void PrintThisBefore()
      => SentenceExampleUnitTests.OutputHelper.WriteLine(this.c.ToString());
  }
}