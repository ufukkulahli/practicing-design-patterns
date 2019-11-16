namespace practicing_design_patterns.behavioral.@object.command.text_editor_app
{
  public class UndoCommand : Command
  {
    public UndoCommand(TextArea textArea, Clipboard clipboard) :
      base(textArea, clipboard)
    {
    }

    public override void Execute()
    {
      return;
    }
  }
}