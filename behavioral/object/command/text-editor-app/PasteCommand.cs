namespace practicing_design_patterns.behavioral.@object.command.text_editor_app
{
  public sealed class PasteCommand : Command
  {
    public PasteCommand(TextArea textArea, Clipboard clipboard) :
      base(textArea, clipboard)
    {
    }

    public override void Execute()
    {
      base.TextArea.ReplaceSelectionWith(base.Clipboard.value);
    }
  }
}
