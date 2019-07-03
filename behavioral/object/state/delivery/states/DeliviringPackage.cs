namespace practicing_design_patterns.behavioral.@object.state.delivery.states
{
  public sealed class DeliviringPackage : IPackageState
  {
  	public string Update(Delivery delivery)
  	{
  		DeliveryUnitTests.OutputHelper.WriteLine("Deliviring the package.");
  		return "Deliviring the package.";
  	}
  }
}