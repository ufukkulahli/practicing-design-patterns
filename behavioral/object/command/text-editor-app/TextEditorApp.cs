namespace practicing_design_patterns.behavioral.@object.command.text_editor_app
{
  public sealed class TextEditorApp
  {
    private readonly Clipboard clipboard;
    private readonly TextArea textArea;
    private readonly CommandHistory history;

    public TextEditorApp(Clipboard clipboard, TextArea textArea)
    {
      this.clipboard = clipboard;
      this.textArea = textArea;
      this.history = new CommandHistory();
    }
    public void ExecuteCommand(Command command)
    {
      command.Execute();
      this.history.Add(command);
    }
    public string ClipboardValue() => this.clipboard.value;
    public void Undo() => history.LastCommand()?.Undo();
  }
}
