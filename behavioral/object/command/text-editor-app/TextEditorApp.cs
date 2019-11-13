namespace practicing_design_patterns.behavioral.@object.command.text_editor_app
{
  public sealed class TextEditorApp
  {
    private readonly Clipboard clipboard;
    private readonly TextArea textArea;
    public TextEditorApp(Clipboard clipboard, TextArea textArea)
    {
      this.clipboard = clipboard;
      this.textArea = textArea;
    }
    public void ExecuteCommand(Command command) => command.Execute();
    public string ClipboardValue() => this.clipboard.value;
  }
}
