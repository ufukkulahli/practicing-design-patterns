using Xunit;

namespace practicing_design_patterns.structural.@class.adapter.phone_charge
{
  public class PhoneChargeUnitTests
  {
    [Fact]
    public void ChargesPhoneWithUSAChargerAdapter()
    {
      // ARRANGE
      var phone = new @object.adapter.phone_charge.Phone(new USAChargerAdapter());

      // ACT
      phone.Charge();

      // ASSERT
      Assert.Equal(500, phone.batteryLevel);
    }
  }
}