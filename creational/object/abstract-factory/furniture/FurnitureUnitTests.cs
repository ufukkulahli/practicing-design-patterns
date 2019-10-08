using Xunit;

namespace practicing_design_patterns.creational.@object.abstract_factory.furniture
{
  public class FurnitureUnitTests
  {
    [Fact]
    public void CreateClassicThemedFurniture()
    {
      // ARRANGE
      FurnitureFactory classicThemedFurnitureFactory = new ClassicThemedFactory();

      // ACT
      var chair = classicThemedFurnitureFactory.CreateChair();
      var table = classicThemedFurnitureFactory.CreateTable();
      var sofa = classicThemedFurnitureFactory.CreateSofa();

      // ASSERT
      Assert.Equal("Classic chair, Wooden, 1x1x1", chair.ToString());
      Assert.Equal("Classic table, Wooden, 3x1x1", table.ToString());
      Assert.Equal("Classic sofa, Wooden, 2x1x1", sofa.ToString());
    }
  }
}
