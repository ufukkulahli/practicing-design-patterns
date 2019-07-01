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
    
    [Fact]
    public void PressesButtonsRespectively()
    {
      // ARRANGE
      var tv = new Tv();

      // ACT
      var stateOfTv1 = tv.PressOnButton();
      var stateOfTv2 = tv.PressMuteButton();
      var stateOfTv3 = tv.PressOffButton();

      // ASSERT
      Assert.Equal("Tv is on.", stateOfTv1);
      Assert.Equal("Tv is muted.", stateOfTv2);
      Assert.Equal("Tv is off.", stateOfTv3);
    }
  }
}