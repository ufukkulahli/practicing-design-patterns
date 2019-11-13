namespace practicing_design_patterns.behavioral.@object.command.text_editor_app
{
    public sealed class TextArea
    {
      private string text;
      public void ReplaceSelectionWith(string text)=>this.text=text;
      public string Value()=>this.text;
    }
}
