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
  }
}
