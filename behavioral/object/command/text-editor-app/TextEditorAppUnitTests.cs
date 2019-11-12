using Xunit;

namespace practicing_design_patterns.behavioral.@object.command.text_editor_app
{
  public class TextEditorUnitTests
  {
    [Fact]
    public void CopiesGivenTextToClipboard()
    {
      // Arrange
      var clipboard = new Clipboard();
      var textEditor = new TextEditorApp(clipboard);
      Command copyCommand = new CopyCommand(clipboard, "Text to be copied");
      
      // Act
      textEditor.ExecuteCommand(copyCommand);

      // Assert
      Assert.Equal("Text to be copied", textEditor.ClipboardValue());
    }

    [Fact]
    public void CutsGivenTextToClipboard()
    {
      // Arrange
      var clipboard = new Clipboard();
      var textEditor = new TextEditorApp(clipboard);
      Command cutCommand = new CutCommand(clipboard, "Text to be cut");

      // Act
      textEditor.ExecuteCommand(cutCommand);

      // Assert
      Assert.Equal("Text to be cut", textEditor.ClipboardValue());
    }
  }
}
