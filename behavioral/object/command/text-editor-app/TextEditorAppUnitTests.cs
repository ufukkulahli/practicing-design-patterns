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
      var textArea = new TextArea();
      var textEditor = new TextEditorApp(clipboard, textArea);
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
      var textArea = new TextArea();
      var textEditor = new TextEditorApp(clipboard, textArea);
      Command cutCommand = new CutCommand(clipboard, textArea);

      // Act
      textEditor.ExecuteCommand(cutCommand);

      // Assert
      Assert.Equal("Hello", textEditor.ClipboardValue());
    }

    [Fact]
    public void PastesGivenTextFromClipboardToTextEditor()
    {
      // Arrange
      var clipboard = new Clipboard();
      var textArea = new TextArea();
      var textEditor = new TextEditorApp(clipboard, textArea);
      Command cutCommand = new CutCommand(clipboard, textArea);
      textEditor.ExecuteCommand(cutCommand);

      Command pasteCommand = new PasteCommand(clipboard, textArea);

      // Act
      textEditor.ExecuteCommand(pasteCommand);

      // Assert
      Assert.Equal(" World!Hello", textArea.Value());
    }

    [Fact]
    public void UndoCommandDoesNothingForNow()
    {
      // Arrange
      var clipboard = new Clipboard();
      var textArea = new TextArea();
      var textEditor = new TextEditorApp(clipboard, textArea);

      Command pasteCommand = new UndoCommand();

      // Act
      textEditor.ExecuteCommand(pasteCommand);

      // Assert
      Assert.Equal("Hello World!", textArea.Value());
    }
  }
}