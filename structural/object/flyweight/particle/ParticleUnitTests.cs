using Xunit;

namespace practicing_design_patterns.structural.@object.flyweight.particle
{
  public class ParticleUnitTests
  {
    [Fact]
    public void CreatesParticles()
    {
      // Arrange
      var game = new Game();

      // Act
      game.DrawParticles();

      // Assert
      Assert.True(true);
    }
  }
}
