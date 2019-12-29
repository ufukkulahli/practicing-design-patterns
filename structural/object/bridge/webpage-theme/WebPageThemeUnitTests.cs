using Xunit;

namespace practicing_design_patterns.structural.@object.bridge.webpage_theme
{
  public class WebPageThemeUnitTests
  {
    [Fact]
    public void HomePagesDefaultThemeIsLight()
    {
      // Arrange
      WebPage homePage = new HomePage();

      // Act
      var homePageContent = homePage.Content();

      // Assert
      Assert.Equal("You are viewing home page in default theme which is light", homePageContent);
    }
  }
}
