namespace practicing_design_patterns.behavioral.@object.command.text_editor_app
{
  public sealed class CopyCommand : Command
  {
    private readonly Clipboard clipboard;
    private readonly string valueToBeCopied;

    public CopyCommand(Clipboard clipboard, string valueToBeCopied)
    {
      this.clipboard = clipboard;
      this.valueToBeCopied = valueToBeCopied;
    }
    public override void Execute() => this.clipboard.value = this.valueToBeCopied;
  }
}
