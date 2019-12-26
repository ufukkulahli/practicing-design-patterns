namespace practicing_design_patterns.structural.@object.bridge.product
{
  public sealed class Tv : Product
  {
    private IState state;
    public Tv() => this.state = new OffState();
    public Tv(IState state) => this.state = state;
    public override string ChangeState() => this.state.Change();
    public override string ChangeState(IState state) => state.Change();
  }
}
