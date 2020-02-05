using System;
namespace practicing_design_patterns.creational.@object.builder.computer
{
  public sealed class ComputerBuilder
  {
    private IMotherboard motherboard;
    private IRam ram;
    private IGraphicsCard graphicsCard;

    public Computer Build() => throw new NotImplementedException();

    public ComputerBuilder Motherboard(IMotherboard motherboard)
    {
      this.motherboard = motherboard;
      return this;
    }

    public ComputerBuilder Ram(IRam ram)
    {
      this.ram = ram;
      return this;
    }
    
    public ComputerBuilder GraphicsCard(IGraphicsCard graphicsCard)
    {
      this.graphicsCard = graphicsCard;
      return this;
    }
  }
}