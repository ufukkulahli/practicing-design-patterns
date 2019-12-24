namespace practicing_design_patterns.structural.@object.bridge.product
{
  public sealed class Tv : Product
  {
    private IState state;
    public Tv(IState state) => this.state = state;
    public override string ChangeState() => this.state.Change();
  }
}
