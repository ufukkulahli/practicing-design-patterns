using Xunit;

namespace practicing_design_patterns.behavioral.@class
{
  public class SortingUnitTests
  {
    [Fact]
    public void Test_Should_SortAscending()
    {
      // Arrange
      var sortAscending = new SortAscending();

      // Act
      sortAscending.DoSort();
    }

    [Fact]
    public void Test_Should_SortDescending()
    {
      // Arrange
      var sortAscending = new SortAscending();

      // Act
      sortAscending.DoSort();
    }
  }
}