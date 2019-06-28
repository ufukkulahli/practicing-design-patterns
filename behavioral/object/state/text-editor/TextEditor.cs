namespace practicing_design_patterns.behavioral.@object.state.text_editor
{
  public sealed class TextEditor
  {
    private ITextState textState;

    public TextEditor() => this.textState = new DefaultCase();

    public void ChangeState(ITextState state)
    {
      this.textState = state;
    }

    public string Type(string text)
    {
      return this.textState.Change(text);
    }
  }
}