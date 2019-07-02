using Xunit;
using Xunit.Abstractions;

namespace practicing_design_patterns.behavioral.@object.state.delivery
{
  public class DeliveryUnitTests
  {
    public static ITestOutputHelper OutputHelper;

    public DeliveryUnitTests(ITestOutputHelper outputHelper) => OutputHelper = outputHelper;

    [Fact]
    public void Test()
    {
      // ARRANGE
      var delivery = new Delivery();

      // ACT
      var obtainedPackage = delivery.ProceedToNextStep();
      var shippedPackage = delivery.ProceedToNextStep();
      var transportingPackage = delivery.ProceedToNextStep();
      var deliviringPackage = delivery.ProceedToNextStep();
      var deliviredPackage = delivery.ProceedToNextStep();

      // ASSERT
      Assert.Equal("Obtained the Package", obtainedPackage);
      Assert.Equal("Shipped the Package", shippedPackage);
      Assert.Equal("Transporting the Package", transportingPackage);
      Assert.Equal("Deliviring the Package", deliviringPackage);
      Assert.Equal("Delivired the Package", deliviredPackage);
    }
  }
}