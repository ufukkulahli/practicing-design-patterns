namespace practicing_design_patterns.behavioral.@object.command.text_editor_app
{
  public sealed class PasteCommand : Command
  {
    private Clipboard clipboard;
    private readonly TextArea textArea;
    private string value;

    public PasteCommand(Clipboard clipboard, TextArea textArea)
    {
      this.clipboard = clipboard;
      this.textArea = textArea;
    }

    public override void Execute()
    {
      this.textArea.ReplaceSelectionWith(this.clipboard.value);
    }
  }
}
