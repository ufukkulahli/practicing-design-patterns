namespace practicing_design_patterns.structural.@object.bridge.product
{
  public abstract class Product
  {
    public abstract string ChangeState();
    public abstract string ChangeState(IState state);
  }
}
