namespace practicing_design_patterns.behavioral.@object.command.text_editor_app
{
  public abstract class Command
  {
    protected readonly TextArea TextArea;
    protected readonly Clipboard Clipboard;

    protected Command(TextArea textArea, Clipboard clipboard)
    {
      this.TextArea = textArea;
      this.Clipboard = clipboard;
    }

    public abstract void Execute();
  }
}
