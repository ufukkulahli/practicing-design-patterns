using Xunit;

namespace practicing_design_patterns.creational.@object.singleton.connection_string
{
  public class ConnectionStringUnitTests
  {
    [Fact]
    public void CreatesOneInstanceOfConnectionString()
    {
      // Arrange
      var instance = ConnectionString.Instance();
      var value = instance.Value();

      // Act

      // Assert
      Assert.Equal("database=localhost;user=admin;pass=admin", value);
    }
  }
}