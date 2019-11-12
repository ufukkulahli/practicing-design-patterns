namespace practicing_design_patterns.behavioral.@object.command.text_editor_app
{
  public sealed class CutCommand : Command
  {
    private Clipboard clipboard;
    private string value;

    public CutCommand(Clipboard clipboard, string value)
    {
      this.clipboard = clipboard;
      this.value = value;
    }

    public override void Execute()
    {
      this.clipboard.value = this.value;
    }
  }
}
