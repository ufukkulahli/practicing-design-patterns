namespace practicing_design_patterns.behavioral.@object.command.text_editor_app
{
  public sealed class TextArea
  {
    private string text = "Hello World!";
    public void SetText(string text) => this.text = text;
    public void ReplaceSelectionWith(string text) => this.text += text;
    public string Delete() => this.text = this.text.Substring(5, 7);
    public string Selection() => this.text.Substring(0, 5);
    public string Value() => this.text;
  }
}
