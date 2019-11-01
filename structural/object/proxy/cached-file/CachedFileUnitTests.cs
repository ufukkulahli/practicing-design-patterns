using Xunit;

namespace practicing_design_patterns.structural.@object.proxy.cached_file
{
  public class CachedFileUnitTests
  {
    [Fact]
    public void FileIsBeingReadEveryTimeSinceItIsNotCached()
    {
      // Arrange
      File monthlyReport = new MonthlyReport();

      // Act
      FileContent monthlyReportContent = monthlyReport.content();

      // Assert
      Assert.Equal("Current month's report as follows...", monthlyReportContent.ToString());
    }
  }
}
