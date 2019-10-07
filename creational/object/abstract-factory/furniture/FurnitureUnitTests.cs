using Xunit;

namespace practicing_design_patterns.creational.@object.abstract_factory.furniture
{
  public class FurnitureUnitTests
  {
    [Fact]
    public void CreateClassicThemedFurniture()
    {
      // ARRANGE
      FurnitureFactory furnitureFactory = new ClassicThemedFactory();

      // ACT
      var chair = furnitureFactory.Create();

      // ASSERT
      Assert.Equal("Classic chair, Wooden, 1x1x1", chair.ToString());
    }
  }
}
