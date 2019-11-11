namespace practicing_design_patterns.behavioral.@object.command.text_editor_app
{
  public sealed class TextEditorApp
  {
    private readonly Clipboard clipboard;
    public TextEditorApp(Clipboard clipboard) => this.clipboard = clipboard;
    public void ExecuteCommand(Command command) => command.Execute();
    public string ClipboardValue() => this.clipboard.value;
  }
}
