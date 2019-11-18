namespace practicing_design_patterns.behavioral.@object.command.text_editor_app
{
  public abstract class Command
  {
    protected readonly TextArea TextArea;
    protected readonly Clipboard Clipboard;
    private string backup = string.Empty;

    protected Command(TextArea textArea, Clipboard clipboard)
    {
      this.TextArea = textArea;
      this.Clipboard = clipboard;
    }

    public abstract void Execute();
    public abstract bool IsUndoable();
    public void BackUpText() => this.backup = TextArea.Value();
    public void Undo() => TextArea.SetText(this.backup);
  }
}
