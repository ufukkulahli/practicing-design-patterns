namespace practicing_design_patterns.behavioral.@object.state.delivery.states
{
  public sealed class TransportingPackage : IPackageState
  {
  	public string Update(Delivery delivery)
  	{
  		DeliveryUnitTests.OutputHelper.WriteLine("Transporting the package.");
  		return "Transporting the package.";
  	}
  }
}