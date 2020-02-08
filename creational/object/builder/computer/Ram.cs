namespace practicing_design_patterns.creational.@object.builder.computer
{
  public sealed class Ram : IRam
  {
    private string size;
    public Ram(string size) => this.size = size;
    public string Size() => this.size;
  }
}