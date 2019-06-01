using practicing_design_patterns.structural.@object.adapter.phone_charge;

namespace practicing_design_patterns.structural.@class.adapter.phone_charge
{
  internal class USAChargerAdapter : USACharger, ICharger
  {
    public new int Charge()
    {
      return base.Charge();
    }
  }
}