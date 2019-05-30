namespace practicing_design_patterns.structural.@object.adapter.phone_charge
{
  class USAChargerAdapter : ICharger
  {
    readonly USACharger USACharger;
    USAChargerAdapter(USACharger uSACharger) => this.USACharger = uSACharger;
    public int Charge() => this.USACharger.Charge();
  }
}