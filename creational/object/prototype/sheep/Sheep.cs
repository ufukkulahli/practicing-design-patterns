namespace practicing_design_patterns.creational.@object.prototype.sheep
{
  public sealed class Sheep
  {
    private string name;
    private string kind;

    public Sheep(string name, string kind)
    {
      this.name = name;
      this.kind = kind;
    }

    public Sheep Clone() => MemberwiseClone() as Sheep;
    public void Name(string name) => this.name = name;
    public string Name() => this.name;
  }
}