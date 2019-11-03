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
      FileContent monthlyReportContent2 = monthlyReport.Content();
      FileContent monthlyReportContent3 = monthlyReport.Content();

      // Assert
      Assert.Equal("Current month's report as follows...", monthlyReportContent.ToString());
      Assert.False(ReferenceEquals(monthlyReportContent, monthlyReportContent2));
      Assert.False(ReferenceEquals(monthlyReportContent2, monthlyReportContent3));
    }

    [Fact]
    public void CachedReportIsBeingServedToClientBecauseOfProxyObject()
    {
      // Arrange
      var cachedMonthlyReport = new Client(new CachedMonthlyReport()).ObtainReport();

      // Act
      FileContent monthlyReportContent = cachedMonthlyReport.Content();
      FileContent monthlyReportContent2 = cachedMonthlyReport.Content();
      FileContent monthlyReportContent3 = cachedMonthlyReport.Content();

      // Assert
      Assert.Equal("Current month's report as follows...", monthlyReportContent.ToString());
      Assert.True(ReferenceEquals(monthlyReportContent, monthlyReportContent2));
      Assert.True(ReferenceEquals(monthlyReportContent2, monthlyReportContent3));
    }
  }
}
