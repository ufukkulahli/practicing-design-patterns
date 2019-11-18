namespace practicing_design_patterns.behavioral.@object.command.text_editor_app
{
  public class UndoCommand : Command
  {
    private readonly TextEditorApp textEditorApp;

    public UndoCommand(TextArea textArea, Clipboard clipboard, TextEditorApp textEditorApp) :
      base(textArea, clipboard)
    {
      this.textEditorApp = textEditorApp;
    }

    public override void Execute() => this.textEditorApp.Undo();
    public override bool IsUndoable() => false;
  }
}
