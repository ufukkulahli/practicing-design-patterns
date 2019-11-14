namespace practicing_design_patterns.behavioral.@object.command.text_editor_app
{
  public sealed class CutCommand : Command
  {
    private Clipboard clipboard;
    private TextArea textArea;

    public CutCommand(Clipboard clipboard, TextArea textArea)
    {
      this.clipboard = clipboard;
      this.textArea = textArea;
    }

    public override void Execute()
    {
      this.clipboard.value = this.textArea.Selection();
      this.textArea.Delete();
    }
  }
}
