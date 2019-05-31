using Xunit;

namespace practicing_design_patterns.structural.@object.adapter.phone_charge
{
  public class PhoneChargeUnitTests
  {
    [Fact]
    public void ChargesPhoneWithEUCharger()
    {
      // ARRANGE
      var phone = new Phone(new EUCharger());

      // ACT
      phone.Charge();

      // ASSERT
      Assert.Equal(750, phone.batteryLevel);
    }
    
    [Fact]
    public void ChargesPhoneWithUSAChargerAdapter()
    {
      // ARRANGE
      var phone = new Phone(new USAChargerAdapter(new USACharger()));

      // ACT
      phone.Charge();

      // ASSERT
      Assert.Equal(500, phone.batteryLevel);
    }
  }
}