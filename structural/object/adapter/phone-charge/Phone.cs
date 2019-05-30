namespace practicing_design_patterns.structural.@object.adapter.phone_charge
{
  class Phone
  {
    int batteryLevel;
    ICharger charger;
    Phone(ICharger charger) => this.charger = charger;
    void Charge() => this.batteryLevel = this.charger.Charge(); 
  }
}