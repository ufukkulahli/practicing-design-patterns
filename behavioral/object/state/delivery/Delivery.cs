namespace practicing_design_patterns.behavioral.@object.state.delivery
{
  public class Delivery
  {
    private IPackageState packageState;
    public Delivery(IPackageState packageState) => this.packageState = packageState;
    public string ProceedToNextStep() => this.packageState.Update(this);
    public void UpdatePackageState(IPackageState packageState) => this.packageState = packageState;
  }
}