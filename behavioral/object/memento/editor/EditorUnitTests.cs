using Xunit;

namespace practicing_design_patterns.behavioral.@object.memento.editor
{
  public class EditorUnitTests
  {
    [Fact]
    public void EditorSavesItsContentAndThenRestoresItBack()
    {
      // Arrange
      var editor = new Editor();
      editor.Content("First text.");
      editor.Content("Second text.");
      // (Save the current state)
      editor.Save();
      editor.Content("First text.");

      // Act
      editor.RestoreContent();

      // Assert
      Assert.Equal("First text.Second text.", editor.Content());
    }

    [Fact]
    public void SavesAndRestoresContentFromHistory()
    {
      // Arrange & Act
      var editor = new Editor();
      editor.Content("First text.");
      editor.Content("Second text.");
      editor.SaveToHistory();
      editor.Content("Third text.");
      editor.SaveToHistory();

      // Act
      editor.RestoreContentFromHistory();
      // Assert
      Assert.Equal("First text.Second text.Third text.", editor.Content());

      // Act
      editor.RestoreContentFromHistory();
      // Assert
      Assert.Equal("First text.Second text.", editor.Content());
    }
  }
}
