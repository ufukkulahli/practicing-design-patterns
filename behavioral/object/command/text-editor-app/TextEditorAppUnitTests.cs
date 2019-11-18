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
      Command copyCommand = new CopyCommand(textArea,clipboard);

      // Act
      textEditor.ExecuteCommand(copyCommand);

      // Assert
      Assert.Equal("Hello", textEditor.ClipboardValue());
    }

    [Fact]
    public void CutsGivenTextToClipboard()
    {
      // Arrange
      var clipboard = new Clipboard();
      var textArea = new TextArea();
      var textEditor = new TextEditorApp(clipboard, textArea);
      Command cutCommand = new CutCommand(textArea, clipboard);

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
      Command cutCommand = new CutCommand(textArea, clipboard);
      textEditor.ExecuteCommand(cutCommand);

      Command pasteCommand = new PasteCommand(textArea, clipboard);

      // Act
      textEditor.ExecuteCommand(pasteCommand);

      // Assert
      Assert.Equal(" World!Hello", textArea.Value());
    }

    [Fact]
    public void UndoChanges()
    {
      // Arrange
      var clipboard = new Clipboard();
      var textArea = new TextArea();
      var textEditor = new TextEditorApp(clipboard, textArea);

      // (Cut the 'Hello')
      Command cutCommand = new CutCommand(textArea, clipboard);
      textEditor.ExecuteCommand(cutCommand);
      Assert.Equal(" World!", textArea.Value());

      Command undoCommand = new UndoCommand(textArea, clipboard, textEditor);

      // Act
      textEditor.ExecuteCommand(undoCommand);

      // Assert
      Assert.Equal("Hello World!", textArea.Value());
    }

    [Fact]
    public void MultipleCommandExecution()
    {
      // Arrange
      var clipboard = new Clipboard();
      var textArea = new TextArea();
      var textEditor = new TextEditorApp(clipboard, textArea);

      // (Cut the 'Hello')
      Command cutCommand = new CutCommand(textArea, clipboard);
      textEditor.ExecuteCommand(cutCommand);
      Assert.Equal(" World!", textArea.Value());
      Assert.Equal("Hello", clipboard.value);

      // (Copy the selected text; ' Worl')
      Command copyCommand = new CopyCommand(textArea,clipboard);
      textEditor.ExecuteCommand(copyCommand);
      Assert.Equal(" World!", textArea.Value());
      Assert.Equal(" Worl", clipboard.value);

      // (Paste the ' Worl')
      Command pasteCommand = new PasteCommand(textArea, clipboard);
      textEditor.ExecuteCommand(pasteCommand);
      Assert.Equal(" World! Worl", textArea.Value());


      // Act
      Command undoCommand = new UndoCommand(textArea, clipboard, textEditor);
      textEditor.ExecuteCommand(undoCommand);

      // Assert
      Assert.Equal(" World!", textArea.Value());
    }
  }
}
