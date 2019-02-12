using System.Collections.Generic;
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
      
      // Assert
      Assert.Equal(new List<string>{"A","B","C"}, sortAscending.GetItems());
    }

    [Fact]
    public void Test_Should_SortDescending()
    {
      // Arrange
      var sortDescending = new SortDescending();

      // Act
      sortDescending.DoSort();
      
      // Assert
      Assert.Equal(new List<string>{"C","B","A"}, sortDescending.GetItems());
    }
  }
}