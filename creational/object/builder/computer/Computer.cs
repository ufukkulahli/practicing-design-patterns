namespace practicing_design_patterns.creational.@object.builder.computer
{
  public sealed class Computer
  {
    private IMotherboard motherboard;
    private IRam ram;
    private IGraphicsCard graphicsCard;
    private IHardDiskDrive hdd;
    private ICPU cpu;

    public Computer
    (
      IMotherboard motherboard,
      IRam ram,
      IGraphicsCard graphicsCard,
      IHardDiskDrive hdd,
      ICPU cpu
    )
    {
      this.motherboard = motherboard;
      this.ram = ram;
      this.graphicsCard = graphicsCard;
      this.hdd = hdd;
      this.cpu = cpu;
    }
  }
}