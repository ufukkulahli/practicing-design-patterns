using Xunit;
using Xunit.Abstractions;

namespace practicing_design_patterns.behavioral.@object.state.tv
{
  public class TvUnitTests
  {
    public static ITestOutputHelper OutputHelper;

    public TvUnitTests(ITestOutputHelper outputHelper) => OutputHelper = outputHelper;

    [Fact]
    public void TvStateIsOffWhenPressedOfButton()
    {
      // ARRANGE
      var tv = new Tv();

      // ACT
      var stateOfTv = tv.PressOffButton();

      // ASSERT
      Assert.Equal("Tv is already off.", stateOfTv);
    }

    [Fact]
    public void TvStateIsOnWhenPressedOfButton()
    {
      // ARRANGE
      var tv = new Tv();

      // ACT
      var stateOfTv = tv.PressOnButton();

      // ASSERT
      Assert.Equal("Tv is on.", stateOfTv);
    }
  }
}