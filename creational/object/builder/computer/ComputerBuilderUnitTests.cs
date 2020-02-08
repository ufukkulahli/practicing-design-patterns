using Xunit;

namespace practicing_design_patterns.creational.@object.builder.computer
{
  public class ComputerBuilderUnitTests
  {
    [Fact]
    public void BuildsCustomComputer()
    {
      // Arrange
      var computerBuilder = new ComputerBuilder();

      // Act
      var computer = computerBuilder
                        .Motherboard(new OEMMotherboard())
                        .Ram(new OEMRam("16GB"))
                        .GraphicsCard(new OEMGraphicsCard("8GB"))
                        .HardDiskDrive(new OEMHDD("1TB"))
                        .CPU(new CPU("Intel i7"))
                        .Build();

      // Assert
      Assert.Equal("OEMMotherboard, 16GB RAM, 8GB graphics card, 1TB HDD, Intel i7", computer.HardwareInfo());
    }

    [Fact]
    public void BuildsCustomComputerWithNonOEMParts()
    {
      // Arrange
      var computerBuilder = new ComputerBuilder();

      // Act
      var computer = computerBuilder
                        .Motherboard(new MotherBoard("Gigabyte"))
                        .Ram(new Ram("Kingstone 32GB"))
                        .GraphicsCard(new GraphicsCard("Nvidia 16GB"))
                        .HardDiskDrive(new HDD("Seagate 1TB"))
                        .CPU(new CPU("Intel i7"))
                        .Build();

      // Assert
      Assert.Equal
      (
        "Gigabyte, Kingstone 32GB RAM, Nvidia 16GB graphics card, Seagate 1TB HDD, Intel i7",
        computer.HardwareInfo()
      );
    }
  }
}