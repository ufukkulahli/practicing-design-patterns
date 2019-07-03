namespace practicing_design_patterns.behavioral.@object.state.delivery.states
{
  public sealed class ObtainedPackage : IPackageState
  {
  	public string Update(Delivery delivery)
  	{
  		DeliveryUnitTests.OutputHelper.WriteLine("Obtained the package.");
			delivery.ProceedToNextStep();
  		return "Obtained the package.";
  	}
  }
}