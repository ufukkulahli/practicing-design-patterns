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

      // Assert
      Assert.True(true);
    }
  }
}