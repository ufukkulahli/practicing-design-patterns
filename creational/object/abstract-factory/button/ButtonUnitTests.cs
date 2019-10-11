using Xunit;

namespace practicing_design_patterns.creational.@object.abstract_factory.button
{
  public class ButtonUnitTests
  {
    [Fact]
    public void CreatesIOSButton()
    {
      // Arrange
      UIFactory iOSfactory = new IOSUIFactory();
      Button iosButton = iOSfactory.Create();

      // Act
      var actual = iosButton.Render();

      // Assert
      Assert.Equal("Here is the iOS button.", actual);
    }

    [Fact]
    public void CreatesAndroidButton()
    {
      // Arrange
      UIFactory androidfactory = new AndroidUIFactory();
      Button androidButton = androidfactory.Create();

      // Act
      var actual = androidButton.Render();

      // Assert
      Assert.Equal("Here is the Android button.", actual);
    }

    [Fact]
    public void CreatesWindowsButton()
    {
      // Arrange
      UIFactory windowsfactory = new WindowsUIFactory();
      Button windowsButton = windowsfactory.Create();

      // Act
      var actual = windowsButton.Render();

      // Assert
      Assert.Equal("Here is the Windows button.", actual);
    }
  }
}
