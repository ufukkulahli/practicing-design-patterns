namespace practicing_design_patterns.behavioral.@object.state.text_editor
{
  public sealed class LowerCase : ITextState
  {
    public string Change(string text)
    {
      TextEditorUnitTests.OutputHelper.WriteLine(text.ToLower());
      return text.ToLower();
    }
  }
}