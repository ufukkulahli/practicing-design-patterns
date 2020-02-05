namespace practicing_design_patterns.creational.@object.builder.computer
{
  public sealed class OEMGraphicsCard : IGraphicsCard
  {
    private string value;
    public OEMGraphicsCard(string value) => this.value = value;
  }
}