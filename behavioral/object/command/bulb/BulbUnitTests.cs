using Xunit;

namespace practicing_design_patterns.behavioral.@object.command.bulb
{
  public class BulbUnitTests
  {
    [Fact]
    public void TurnsOnTheBulb()
    {
      // Arrange
      var bulb = new Bulb();
      Command turnOnCommand = new TurnOn(bulb);
      var remote = new RemoteControl();

      // Act
      remote.Submit(turnOnCommand);

      // Assert
      Assert.True(bulb.IsOn());
    }
  }
}
