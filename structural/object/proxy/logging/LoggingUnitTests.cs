using Xunit;

namespace practicing_design_patterns.structural.@object.proxy.logging
{
  public class LoggingUnitTests
  {
    [Fact]
    public void LoggingProxyObjectLogsRequest()
    {
      // Arrange
      IHttpClient httpClient = new HttpClient();

      // Act
      httpClient.Post("www.helloworld.com", "hello");
    }
  }
}
