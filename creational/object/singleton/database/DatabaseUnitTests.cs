using Xunit;

namespace practicing_design_patterns.creational.@object.singleton.database
{
  public class DatabaseUnitTests
  {
    [Fact]
    public void CreatesSingleInstanceOfDatabase()
    {
      // Arrange & Act
      var db = Database.Instance();
      var db2 = Database.Instance();

      // Assert
      Assert.True(db.Equals(db2));
    }
  }
}