using System;
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
                        .Ram(new OEMRam("16GB"));

      // Assert
      Assert.Throws<NotImplementedException>(() => computer.Build());
    }
  }
}