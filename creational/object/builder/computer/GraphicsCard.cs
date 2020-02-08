namespace practicing_design_patterns.creational.@object.builder.computer
{
  public sealed class GraphicsCard : IGraphicsCard
  {
    private string size;
    public GraphicsCard(string size) => this.size = size;
    public string Size() => this.size;
  }
}