namespace practicing_design_patterns.behavioral.@object.memento.editor
{
  public sealed class ContentSnapshot
  {
    private readonly string content;
    public ContentSnapshot(string content) => this.content = content;
    public string Value() => this.content;
  }
}
