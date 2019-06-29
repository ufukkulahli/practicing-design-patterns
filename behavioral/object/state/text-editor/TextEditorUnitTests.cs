using Xunit;
using Xunit.Abstractions;

namespace practicing_design_patterns.behavioral.@object.state.text_editor
{
  public class TextEditorUnitTests
  {
    public static ITestOutputHelper OutputHelper;

    public TextEditorUnitTests(ITestOutputHelper outputHelper) => OutputHelper = outputHelper;

    [Fact]
    public void TextIsInDefaultState()
    {
      // ARRANGE
      var textEditor = new TextEditor();

      // ACT
      var text = textEditor.Type("Hello");

      // ASSERT
      Assert.Equal("Hello", text);
    }
    
    [Fact]
    public void TextHasVariousStates()
    {
      // ARRANGE
      var textEditor = new TextEditor();

      // ACT
      var text = textEditor.Type("Hello");
      textEditor.ChangeState(new UpperCase());
      var upperCaseText = textEditor.Type("Hello");
      textEditor.ChangeState(new LowerCase());
      var lowerCaseText = textEditor.Type("Hello");

      // ASSERT
      Assert.Equal("Hello", text);
      Assert.Equal("HELLO", upperCaseText);
      Assert.Equal("hello", lowerCaseText);
    }
  }
}