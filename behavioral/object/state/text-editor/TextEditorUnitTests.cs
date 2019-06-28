using Xunit;
using Xunit.Abstractions;

namespace practicing_design_patterns.behavioral.@object.state.text_editor
{
  public class TextEditorUnitTests
  {
    public static ITestOutputHelper OutputHelper;

    public TextEditorUnitTests(ITestOutputHelper outputHelper) => OutputHelper = outputHelper;

    [Fact]
    public void Test()
    {
      // ARRANGE
      var textEditor = new TextEditor();

      // ACT
      var text = textEditor.Type("Hello");

      // ASSERT
      Assert.Equal("Hello", text);
    }
  }
}