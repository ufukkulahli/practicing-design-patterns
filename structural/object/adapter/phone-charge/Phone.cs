namespace practicing_design_patterns.structural.@object.adapter.phone_charge
{
  class Phone
  {
    internal int batteryLevel {get; private set;}
    ICharger charger;
    internal Phone(ICharger charger) => this.charger = charger;
    internal void Charge() => this.batteryLevel = this.charger.Charge(); 
  }
}