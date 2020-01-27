using Xunit;

namespace practicing_design_patterns.creational.@object.prototype.cell
{
  public class CellUnitTests
  {
    [Fact]
    public void CellSplitsItself()
    {
      // Arrange
      var singleCellOrganism = new SingleCellOrganism();

      // Act
      var newCell = singleCellOrganism.Split();

      // Assert
      Assert.True(newCell.Alive);
    }
  }
}