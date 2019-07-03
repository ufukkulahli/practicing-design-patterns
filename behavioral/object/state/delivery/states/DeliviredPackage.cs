namespace practicing_design_patterns.behavioral.@object.state.delivery.states
{
  public sealed class DeliviredPackage : IPackageState
  {
  	public string Update(Delivery delivery)
  	{
  		DeliveryUnitTests.OutputHelper.WriteLine("Delivired the package.");
  		return "Delivired the package.";
  	}
  }
}