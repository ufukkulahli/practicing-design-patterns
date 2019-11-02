using Xunit;

namespace practicing_design_patterns.structural.@object.proxy.cached_file
{
  public class CachedFileUnitTests
  {
    [Fact]
    public void FileIsBeingReadEveryTimeSinceItIsNotCached()
    {
      // Arrange
      var monthlyReport = new Client(new MonthlyReport()).ObtainReport();

      // Act
      FileContent monthlyReportContent = monthlyReport.Content();

      // Assert
      Assert.Equal("Current month's report as follows...", monthlyReportContent.ToString());
    }

    [Fact]
    public void CachedReportIsBeingServedToClientBecauseOfProxyObject()
    {
      // Arrange
      var cachedMonthlyReport = new Client(new CachedMonthlyReport()).ObtainReport();

      // Act
      FileContent monthlyReportContent = cachedMonthlyReport.Content();

      // Assert
      Assert.Equal("Current month's report as follows...", monthlyReportContent.ToString());
    }
  }
}
