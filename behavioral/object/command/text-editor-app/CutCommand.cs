namespace practicing_design_patterns.behavioral.@object.command.text_editor_app
{
  public sealed class CutCommand : Command
  {
    public CutCommand(TextArea textArea, Clipboard clipboard) :
      base(textArea, clipboard)
    {
    }

    public override void Execute()
    {
      base.Clipboard.value = base.TextArea.Selection();
      base.TextArea.Delete();
    }
  }
}
