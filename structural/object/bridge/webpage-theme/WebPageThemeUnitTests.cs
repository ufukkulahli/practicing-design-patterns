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
    public void HomePagesThemeIsDarkAndAboutPageIsLight()
    {
      // Arrange
      WebPage homePage = new HomePage(new DarkTheme());
      WebPage aboutPage = new AboutPage();

      // Act
      var homePageContent = homePage.Content();
      var aboutPageContent = aboutPage.Content();

      // Assert
      Assert.Equal("You are viewing home page in default theme which is: Dark", homePageContent);
      Assert.Equal("You are viewing home page in default theme which is: Light", aboutPageContent);
    }
  }
}
