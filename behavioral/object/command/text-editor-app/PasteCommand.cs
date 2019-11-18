namespace practicing_design_patterns.behavioral.@object.command.text_editor_app
{
  public sealed class PasteCommand : Command
  {
    public PasteCommand(TextArea textArea, Clipboard clipboard) : base(textArea, clipboard) { }
    public override void Execute()
    {
      base.BackUpText();
      base.TextArea.ReplaceSelectionWith(base.Clipboard.value);
    }
    public override bool IsUndoable() => true;
  }
}
