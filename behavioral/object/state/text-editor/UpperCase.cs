namespace practicing_design_patterns.behavioral.@object.state.text_editor
{
  public sealed class UpperCase : ITextState
  {
    public string Change(string text)
    {
      TextEditorUnitTests.OutputHelper.WriteLine(text.ToUpper());
      return text.ToUpper();
    }
  }
}