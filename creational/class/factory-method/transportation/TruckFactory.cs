namespace practicing_design_patterns.creational.@class.factory_method.transportation
{
  public sealed class TruckFactory : TransportFactory
  {
    public override Transport CreateTransportationVehicle() => new Truck();
  }
}
