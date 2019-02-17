namespace practicing_design_patterns.behavioral.@object.visitor
{
  public class Name
  {
    private readonly string value;
    public Name(string value) =>
      this.value = value.ThrowIfNull();
    public string GetName() => this.value;
    public override string ToString() => this.value;
  }
}