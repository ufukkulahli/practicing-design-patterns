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
      Assert.Equal("You are viewing home page in default theme which is: Light", homePageContent);
    }

    [Fact]
    public void HomePagesThemeIsDark()
    {
      // Arrange
      WebPage homePage = new HomePage(new DarkTheme());

      // Act
      var homePageContent = homePage.Content();

      // Assert
      Assert.Equal("You are viewing home page in default theme which is: Dark", homePageContent);
    }
  }
}
