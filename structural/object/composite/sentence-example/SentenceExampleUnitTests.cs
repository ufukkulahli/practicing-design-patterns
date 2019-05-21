using Xunit;
using Xunit.Abstractions;

namespace practicing_design_patterns.structural.@object.composite.sentence_example
{
  public class SentenceExampleUnitTests
  {
    public static ITestOutputHelper OutputHelper;

    public SentenceExampleUnitTests(ITestOutputHelper outputHelper) => OutputHelper = outputHelper;

    [Fact]
    public void PrintsHelloWorld()
    {
      // Arrange
      var messenger = new Messenger().ComposeHelloWorld();

      // Act
      messenger.Print();
    }
  }
}
