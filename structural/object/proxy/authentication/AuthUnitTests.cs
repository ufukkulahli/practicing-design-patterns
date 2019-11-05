using Xunit;

namespace practicing_design_patterns.structural.@object.proxy.authentication
{
  public class AuthUnitTests
  {
    [Fact]
    public void ReportIsEmptySinceUserIsNotAllowedToSee()
    {
      // Arrange
      var weeklySalesReport = ProxyWeeklySalesReport.ForUser("John Doe");

      // Act
      var reportContent = weeklySalesReport.Content();

      // Assert
      Assert.True(string.IsNullOrEmpty(reportContent));
    }
  }
}
