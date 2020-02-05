namespace practicing_design_patterns.creational.@object.builder.computer
{
  public sealed class OEMGraphicsCard : IGraphicsCard
  {
    private string memorySize;
    public OEMGraphicsCard(string memorySize) => this.memorySize = memorySize;
  }
}