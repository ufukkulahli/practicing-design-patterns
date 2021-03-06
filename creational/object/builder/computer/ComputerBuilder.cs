namespace practicing_design_patterns.creational.@object.builder.computer
{
  public sealed class ComputerBuilder
  {
    private IMotherboard motherboard;
    private IRam ram;
    private IGraphicsCard graphicsCard;
    private IHardDiskDrive hdd;
    private ICPU cpu;

    public Computer Build() => new Computer(motherboard, ram, graphicsCard, hdd, cpu);

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

    public ComputerBuilder HardDiskDrive(IHardDiskDrive hdd)
    {
      this.hdd = hdd;
      return this;
    }

    public ComputerBuilder CPU(ICPU cpu)
    {
      this.cpu = cpu;
      return this;
    }

    public ComputerBuilder GraphicsCard(IGraphicsCard graphicsCard)
    {
      this.graphicsCard = graphicsCard;
      return this;
    }
  }
}