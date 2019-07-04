namespace practicing_design_patterns.behavioral.@object.state.delivery.states
{
  public sealed class ShippedPackage : IPackageState
  {
  	public string Update(Delivery delivery)
  	{
  		DeliveryUnitTests.OutputHelper.WriteLine("Shipped the package.");
			delivery.UpdatePackageState(new TransportingPackage());
  		return "Shipped the package";
  	}
  }
}